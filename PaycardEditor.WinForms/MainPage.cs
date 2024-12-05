using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PaycardEditor.Applications.Commands.Paycard.RemovePaycard;
using PaycardEditor.Applications.Dtos;
using PaycardEditor.Applications.Queries.Paycard.GetPaycardByCardId;
using PaycardEditor.Applications.Queries.Paycard.GetPaycards;
using PaycardEditor.Applications.Queries.Paycard.GetPaycardsByOwnerAccountNr;
using PaycardEditor.Applications.Queries.Paycard.GetPaycardsBySerialNr;
using PaycardEditor.Domain.Enums;

namespace PaycardEditor.WinForms;

public partial class MainPage : Form
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IMediator _mediator;
    private IEnumerable<PaycardDto> _paycardsDtoList = new List<PaycardDto>();
    private int _index = 0;

    public MainPage(IServiceProvider serviceProvider, IMediator mediator)
    {
        _serviceProvider = serviceProvider;
        _mediator = mediator;

        InitializeComponent();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        var addPage = _serviceProvider.GetRequiredService<AddPaycardPage>();

        addPage.ShowDialog();
    }

    private async void MainPage_LoadAsync(object sender, EventArgs e)
    {
        KindOfSearchComboBox.DataSource = Enum.GetValues(typeof(KindOfSearch));

        await InitializeValuesOfPaycardAsync();
    }

    private void KindOfSearchComboBox_SelectedValueChanged(object sender, EventArgs e)
    {
        switch (KindOfSearchComboBox.SelectedItem)
        {
            case KindOfSearch.NrKonta:
                SearchTextbox.PlaceholderText = "Podaj nr konta w³aœciciela";
                SearchTextbox.MaxLength = 24;
                break;
            case KindOfSearch.NrSeryjny:
                SearchTextbox.PlaceholderText = "Podaj nr seryjny karty";
                SearchTextbox.MaxLength = 16;
                break;
            case KindOfSearch.IdKarty:
                SearchTextbox.PlaceholderText = "Podaj unikalny klucz karty";
                SearchTextbox.MaxLength = 32;
                break;
        }
    }

    private void NextRecordButton_Click(object sender, EventArgs e)
    {
        var paycardsWithNextRecord = new PaycardDto();
        if (_index < _paycardsDtoList.Count())
        {
            _index = _index + 1;

            paycardsWithNextRecord = _paycardsDtoList.Skip(_index - 1).First();

            AsignPaycardParameterToControls(paycardsWithNextRecord);
        }
    }

    private void PreviousRecordButton_Click(object sender, EventArgs e)
    {
        if (_index > 1)
        {
            _index = _index - 1;

            var paycardsWithPreviousRecord = _paycardsDtoList.Skip(_index - 1).First();

            AsignPaycardParameterToControls(paycardsWithPreviousRecord);
        }
    }

    private async void DeleteButton_ClickAsync(object sender, EventArgs e)
    {
        var paycardDto = _paycardsDtoList.Where(x => x.CardId == CardIdTextbox.Text).First();

        var result = MessageBox.Show($"Czy napewno chcesz usun¹æ kartê o unikalnym numerze: {paycardDto.CardId}", "Usuwanie karty", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.No)
        {
            return;
        }

        try
        {
            await _mediator.Send(new RemovePaycardCommand(paycardDto.Id));

            MessageBox.Show($"Pomyœlnie usuniêto kartê o unikalnym numerze: {paycardDto.CardId}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        await InitializeValuesOfPaycardAsync();
    }

    private async void SearchButton_ClickAsync(object sender, EventArgs e)
    {
        var kindOfSearchSelected = KindOfSearchComboBox.SelectedValue;
        string searchElementText = SearchTextbox.Text;

        object query = new();
        switch (kindOfSearchSelected)
        {
            case KindOfSearch.NrKonta:
                query = new GetPaycardsByOwnerAccountNrQuery(searchElementText);
                break;
            case KindOfSearch.NrSeryjny:
                query = new GetPaycardsBySerialNrQuery(searchElementText);
                break;
            case KindOfSearch.IdKarty:
                query = new GetPaycardByCardIdQuery(searchElementText);
                break;
        }

        try
        {
            var result = await _mediator.Send(query);
            List<PaycardDto> paycardDtos = new();
            if (query is GetPaycardByCardIdQuery)
            {
                paycardDtos = new List<PaycardDto>() { (PaycardDto)result };
            }
            else
            {
                paycardDtos = (List<PaycardDto>)result;
            }

            if (paycardDtos.Count == 0)
            {
                MessageBox.Show("Brak kart p³atniczych o wyszukiwanych parametrach.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            await InitializeValuesOfPaycardAsync(true, paycardDtos);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString(), "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void DisplayAllComponentButton_ClickAsync(object sender, EventArgs e)
    {
        await InitializeValuesOfPaycardAsync();
    }

    private void SettingsButton_Click(object sender, EventArgs e)
    {
        var settingsPage = _serviceProvider.GetRequiredService<SettingsPage>();

        settingsPage.ShowDialog();
    }

    public async Task InitializeValuesOfPaycardAsync(bool asSearchComponent = false, List<PaycardDto> paycardDtos = null)
    {
        if (!asSearchComponent)
        {
            try
            {
                _paycardsDtoList = await _mediator.Send(new GetPaycardsQuery());
            }
            catch
            {
                MessageBox.Show("Brak komunikacji z serwerem SQL. PrzejdŸ do ustawieñ aby sprawdziæ po³¹czenie.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            _paycardsDtoList = paycardDtos;
        }

        PaycardsDataGridView.DataSource = _paycardsDtoList = _paycardsDtoList.OrderBy(x => x.Id).ToList();

        var paycardsWithLastRecord = new PaycardDto();
        if (_paycardsDtoList.Count() != 0)
        {
            paycardsWithLastRecord = _paycardsDtoList.Last();
            _index = _paycardsDtoList.Count();

            AsignPaycardParameterToControls(paycardsWithLastRecord);
        }
    }

    private void AsignPaycardParameterToControls(PaycardDto paycardDto)
    {
        OwnerAccountNrTextbox.Text = paycardDto.OwnerAccountNr;
        PINTextbox.Text = paycardDto.PIN.ToString();

        string paycardSerialNrSplit = string.Empty;
        foreach (char c in paycardDto.SerialNr)
        {
            paycardSerialNrSplit += c;

            if (paycardSerialNrSplit.Length % 4 == 0)
            {
                paycardSerialNrSplit += ' ';
            }
        }

        SerialNrLabel.Text = SerialNrTextbox.Text = paycardSerialNrSplit.ToString();
        CardIdTextbox.Text = paycardDto.CardId;
    }
}
