using FluentValidation;

namespace PaycardEditor.Applications.Commands.Paycard.AddPaycard;

public class AddPaycardCommandValidation : AbstractValidator<AddPaycardCommand>
{
    public AddPaycardCommandValidation()
    {
        RuleFor(x => x.OwnerAccountNr)
            .NotEmpty().WithMessage("Nr konta właściciela jest wymagany.")
            .Must(x => HasNotAnyLettersAndSpecialCharacters(x)).WithMessage("Nr konta właściciela musi składać się tylko z cyfr.")
            .Length(24).WithMessage("Nr konta właściciela musi posiadać 24 cyfry.");

        RuleFor(x => x.PIN)
            .NotEmpty().WithMessage("PIN jest wymagany.")
            .Must(x => HasNotAnyLettersAndSpecialCharacters(x.ToString())).WithMessage("PIN musi składać się tylko z cyfr.")
            .Length(4).WithMessage("PIN musi posiadać 4 cyfry."); ;


        RuleFor(x => x.SerialNr)
            .NotEmpty().WithMessage("Nr seryjny karty jest wymagany.")
            .Must(x => HasNotAnyLettersAndSpecialCharacters(x)).WithMessage("Nr seryjny karty musi składać się tylko z cyfr.")
            .Length(16).WithMessage("Nr seryjny karty musi posiadać 16 cyfr.");
    }

    private static bool HasNotAnyLettersAndSpecialCharacters(string numbers)
    {
        bool valid = true;

        foreach (char c in numbers)
        {
            if (char.IsLetter(c) || char.IsSymbol(c))
            {
                valid = false;
                break;
            }
        }

        return valid;
    }
}
