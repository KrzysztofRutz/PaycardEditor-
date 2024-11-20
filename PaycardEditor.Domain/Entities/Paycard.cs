namespace PaycardEditor.Domain.Entities;

public class Paycard : Entity
{
    public string OwnerAccountNr { get; set; }
    public int PIN { get; set; }
    public string SerialNr { get; set; }
    public string CardId { get; set; }
}
