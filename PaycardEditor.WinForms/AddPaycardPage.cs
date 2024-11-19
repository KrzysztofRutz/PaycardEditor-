using MediatR;
using PaycardEditor.Applications.Commands.Paycard.AddPaycard;

namespace PaycardEditor.WinForms;

public partial class AddPaycardPage : Form
{
    private readonly IMediator _mediator;

    public AddPaycardPage(IMediator mediator)
    {
        _mediator = mediator;

        InitializeComponent();     
    }

    private void SubmitButton_Click(object sender, EventArgs e)
    {
        var command = new AddPaycardCommand()
        {
            OwnerAccountNr = int.Parse(OwnerAccountNrTextBox.Text),
            PIN = int.Parse(PINTextBox.Text),
            SerialNr = int.Parse(SerialNrTextBox.Text),
        };

        var result = _mediator.Send(command);

        if (result != null)
        {
            MessageBox.Show("Dodanie karty płatniczej powiodło się.", "Powodzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Dodanie karty płatniczej powiodło się.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
