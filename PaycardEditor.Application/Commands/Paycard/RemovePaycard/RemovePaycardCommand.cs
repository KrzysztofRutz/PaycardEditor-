using PaycardEditor.Applications.Configuration.Commands;

namespace PaycardEditor.Applications.Commands.Paycard.RemovePaycard;

public record RemovePaycardCommand(int id) : ICommand
{
}
