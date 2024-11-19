using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PaycardEditor.Applications.Queries.Paycard.GetPaycardById;
using PaycardEditor.Domain.Enums;

namespace PaycardEditor.WinForms;

public partial class MainPage : Form
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IMediator _mediator;

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
        await InitializeValuesOfPaycard();

        KindOfSearchComboBox.DataSource = Enum.GetValues(typeof(KindOfSearch));
    }

    private async Task InitializeValuesOfPaycard()
    {
        var paycard = await _mediator.Send(new GetPaycardByIdQuery(1));

        OwnerAccountNrTextbox.Text = paycard.OwnerAccountNr.ToString();
        PINTextbox.Text = paycard.PIN.ToString();

        string paycardSplit = string.Empty;
        foreach (char c in paycard.SerialNr.ToString())
        {
            paycardSplit.Append(c);

            if (paycardSplit.Length % 4 == 0)
            {
                paycardSplit.Append(' ');
            }
        }

        SerialNrLabel.Text = SerialNrTextbox.Text = paycardSplit.ToString();
        CardIdTextbox.Text = paycard.CardId;
    }

    private void KindOfSearchComboBox_SelectedValueChanged(object sender, EventArgs e)
    {
        switch (KindOfSearchComboBox.SelectedItem)
        {
            case KindOfSearch.ByOwnerAccountNr:
                KindOfSearchComboBox.Text = "Nr konta w³aœciciela";
                SearchTextbox.PlaceholderText = "Podaj nr konta w³aœciciela";
                break;
            case KindOfSearch.BySerialNr:
                KindOfSearchComboBox.Text = "Nr seryjny karty";
                SearchTextbox.PlaceholderText = "Podaj nr seryjny karty";
                break;
            case KindOfSearch.ByCardId:
                KindOfSearchComboBox.Text = "Unikalny klucz karty";
                SearchTextbox.PlaceholderText = "Podaj unikalny klucz karty";
                break;
        }
    }
}
