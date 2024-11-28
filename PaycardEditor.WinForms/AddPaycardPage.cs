using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PaycardEditor.Applications.Commands.Paycard.AddPaycard;
using PaycardEditor.Applications.Dtos;

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
        
        try
        {
            var result = await _mediator.Send(command);

            MessageBox.Show("Dodanie karty płatniczej powiodło się.", "Powodzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex) 
        {
            MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*
        var result = await _mediator.Send(command);

        if (result is not PaycardDto)
        {
            MessageBox.Show("Dodanie karty płatniczej powiodło się.", "Powodzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Dodanie karty płatniczej nie powiodło się.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }*/

        var mainPage = _serviceProvider.GetRequiredService<MainPage>();
        await mainPage.InitializeValuesOfPaycardAsync();
    }
}
