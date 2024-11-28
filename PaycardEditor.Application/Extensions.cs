using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PaycardEditor.Applications.Commands.Paycard.AddPaycard;
using PaycardEditor.Applications.Configuration.Valdation;
using System.Reflection;

namespace PaycardEditor.Applications;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection serviceCollection)
    {
        var executingAssembly = Assembly.GetExecutingAssembly();
        serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(executingAssembly));
        serviceCollection.AddAutoMapper(executingAssembly);
        serviceCollection.AddValidatorsFromAssembly(executingAssembly);

        serviceCollection.AddScoped<IValidator<AddPaycardCommand>, AddPaycardCommandValidation>();

        serviceCollection.AddTransient(typeof(IPipelineBehavior<,>), typeof(CommandValidationBehavior<,>));

        return serviceCollection;
    }
}
