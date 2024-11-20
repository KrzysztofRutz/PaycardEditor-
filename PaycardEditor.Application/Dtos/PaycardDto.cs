namespace PaycardEditor.Applications.Dtos;

public class PaycardDto
{
    public int Id { get; set; }
    public string OwnerAccountNr { get; set; }
    public int PIN { get; set; }
    public string SerialNr { get; set; }
    public string CardId { get; set; }
}
