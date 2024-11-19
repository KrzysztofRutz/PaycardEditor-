using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaycardEditor.Domain.Abstractions;
using PaycardEditor.Infrastructure.Context;
using PaycardEditor.Infrastructure.Repositories;

namespace PaycardEditor.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

        serviceCollection.AddScoped<IPaycardRepository, PaycardRepository>();

        serviceCollection.AddDbContext<PaycardEditorDbContext>(ctx => ctx.UseSqlServer(configuration.GetConnectionString("PaycardCS")));

        return serviceCollection;
    }
}
