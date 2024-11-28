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

    private async void MainPage_Load(object sender, EventArgs e)
    {
        KindOfSearchComboBox.DataSource = Enum.GetValues(typeof(KindOfSearch));

        await InitializeValuesOfPaycardAsync();
    }

    private void KindOfSearchComboBox_SelectedValueChanged(object sender, EventArgs e)
    {
        switch (KindOfSearchComboBox.SelectedItem)
        {
            case KindOfSearch.ByOwnerAccountNr:
                SearchTextbox.PlaceholderText = "Podaj nr konta w�a�ciciela";
                SearchTextbox.MaxLength = 24;
                break;
            case KindOfSearch.BySerialNr:
                SearchTextbox.PlaceholderText = "Podaj nr seryjny karty";
                SearchTextbox.MaxLength = 16;
                break;
            case KindOfSearch.ByCardId:
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

    private async void DeleteButton_Click(object sender, EventArgs e)
    {
        var paycardDto = _paycardsDtoList.Where(x => x.CardId == CardIdTextbox.Text).First();

        var result = MessageBox.Show($"Czy napewno chcesz usun�� kart� o unikalnym numerze: {paycardDto.CardId}", "Usuwanie karty", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.No)
        {
            return;
        }

        try
        {
            await _mediator.Send(new RemovePaycardCommand(paycardDto.Id));

            MessageBox.Show($"Pomy�lnie usuni�to kart� o unikalnym numerze: {paycardDto.CardId}", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        await InitializeValuesOfPaycardAsync();
    }

    private async void SearchButton_Click(object sender, EventArgs e)
    {
        var kindOfSearchSelected = KindOfSearchComboBox.SelectedValue;
        string searchElementText = SearchTextbox.Text;

        object query = new();
        switch (kindOfSearchSelected)
        {
            case KindOfSearch.ByOwnerAccountNr:
                query = new GetPaycardsByOwnerAccountNrQuery(searchElementText);
                break;
            case KindOfSearch.BySerialNr:
                query = new GetPaycardsBySerialNrQuery(searchElementText);
                break;
            case KindOfSearch.ByCardId:
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

            await InitializeValuesOfPaycardAsync(true, paycardDtos);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString(), "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void DisplayAllComponentButton_Click(object sender, EventArgs e)
    {
        await InitializeValuesOfPaycardAsync();
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
                MessageBox.Show("Brak komunikacji z serwerem SQL. Przejd� do ustawie� aby sprawdzi� po��czenie.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            _paycardsDtoList = paycardDtos;
        }

        dataGridView1.DataSource = _paycardsDtoList = _paycardsDtoList.OrderBy(x => x.Id).ToList();

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
