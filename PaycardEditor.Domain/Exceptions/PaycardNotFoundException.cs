namespace PaycardEditor.Domain.Exceptions;

public class PaycardNotFoundException : PaycardException
{
    public int Id { get; }
    public PaycardNotFoundException(int id)
        : base($"Paycard with ID {id} was not found.")
    {
        Id = id;
    }
}
