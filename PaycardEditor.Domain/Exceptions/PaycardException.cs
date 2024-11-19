namespace PaycardEditor.Domain.Exceptions;

public abstract class PaycardException : Exception
{
    public PaycardException(string message) : base(message)
    {
    }
}
