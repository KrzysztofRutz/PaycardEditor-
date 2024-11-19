namespace PaycardEditor.Applications.Dtos;

public class PaycardDto
{
    public int Id { get; set; }
    public int OwnerAccountNr { get; set; }
    public int PIN { get; set; }
    public int SerialNr { get; set; }
    public string CardId { get; set; }
}
