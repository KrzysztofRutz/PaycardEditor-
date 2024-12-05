using MediatR;
using PaycardEditor.Applications.Commands.Database.UpdateDatabase;
using PaycardEditor.Applications.Queries.Paycard.GetPaycards;
using PaycardEditor.WinForms.Properties;

namespace PaycardEditor.WinForms;

public partial class SettingsPage : Form
{
    private readonly IMediator _mediator;

    public SettingsPage(IMediator mediator)
    {
        _mediator = mediator;

        InitializeComponent();
    }

    private async void CreateDbButton_ClickAsync(object sender, EventArgs e)
    {
        try
        {
            await _mediator.Send(new UpdateDatabaseCommand());

            MessageBox.Show("Pomyślnie utworzono/zaktualizowani bazę danych o nazwie 'PaycardDb'.", "Powodzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"Błąd podczas tworzenia/aktualizacji bazy danych. Powód:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void CheckConnectionDbButton_ClickAsync(object sender, EventArgs e)
    {
        await CheckConnectionDbStateAsync();
    }

    private async void SettingsPage_LoadAsync(object sender, EventArgs e)
    {
        await CheckConnectionDbStateAsync();
    }

    private async Task CheckConnectionDbStateAsync()
    {
        try
        {
            var result = await _mediator.Send(new GetPaycardsQuery());

            ConnectionDbStatePictureBox.Image = Resources.connected;
        }
        catch
        {
            ConnectionDbStatePictureBox.Image = Resources.disconnected;
        }
    }
}
