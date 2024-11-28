using FluentValidation;
using MediatR;
using PaycardEditor.Applications.Configuration.Commands;

namespace PaycardEditor.Applications.Configuration.Valdation;

public class CommandValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : class, ICommand<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public CommandValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (!_validators.Any())
        {
            return await next();
        }

        var context = new ValidationContext<TRequest>(request);
        var errorList = _validators
            .Select(x => x.Validate(context))
            .SelectMany(x => x.Errors)
            .Where(x => x != null)
            .Select(x => x.ErrorMessage)
            .Distinct()
            .ToList();

        if (errorList.Any())
        {
            throw new ValidationException($"Błędna formuła, przyczyny:\n {string.Join("\n", errorList)}");
        }

        return await next();
    }
}
