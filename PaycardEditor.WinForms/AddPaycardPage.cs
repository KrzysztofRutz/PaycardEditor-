using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PaycardEditor.Applications.Commands.Paycard.AddPaycard;

namespace PaycardEditor.WinForms;

public partial class AddPaycardPage : Form
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IMediator _mediator;

    public AddPaycardPage(IServiceProvider serviceProvider, IMediator mediator)
    {
        _serviceProvider = serviceProvider;
        _mediator = mediator;

        InitializeComponent();     
    }

    private async void SubmitButton_Click(object sender, EventArgs e)
    {
        var command = new AddPaycardCommand()
        {
            OwnerAccountNr = OwnerAccountNrTextBox.Text,
            PIN = int.Parse(PINTextBox.Text),
            SerialNr = SerialNrTextBox.Text,
        };

        var result = _mediator.Send(command);

        if (result != null)
        {
            MessageBox.Show("Dodanie karty płatniczej powiodło się.", "Powodzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Dodanie karty płatniczej nie powiodło się.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        var mainPage = _serviceProvider.GetRequiredService<MainPage>();
        await mainPage.InitializeValuesOfPaycardAsync();
    }
}
