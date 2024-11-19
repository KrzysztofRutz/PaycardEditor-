using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace PaycardEditor.Applications;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection serviceCollection)
    {
        var executingAssembly = Assembly.GetExecutingAssembly();
        serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(executingAssembly));
        serviceCollection.AddAutoMapper(executingAssembly);

        return serviceCollection;
    }
}
