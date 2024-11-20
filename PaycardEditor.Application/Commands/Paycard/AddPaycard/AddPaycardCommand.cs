using PaycardEditor.Applications.Configuration.Commands;
using PaycardEditor.Applications.Dtos;

namespace PaycardEditor.Applications.Commands.Paycard.AddPaycard;

public class AddPaycardCommand : ICommand<PaycardDto>
{
    public string OwnerAccountNr { get; set; }
    public int PIN { get; set; }
    public string SerialNr { get; set; }
}
