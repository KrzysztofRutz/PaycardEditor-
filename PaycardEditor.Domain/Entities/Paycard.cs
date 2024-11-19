namespace PaycardEditor.Domain.Entities;

public class Paycard : Entity
{
    public int OwnerAccountNr { get; set; }
    public int PIN { get; set; }
    public int SerialNr { get; set; }
    public string CardId { get; set; }
}
