using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using PaycardEditor.Domain.Abstractions;
using PaycardEditor.Domain.Settings;
using PaycardEditor.Infrastructure.Context;
using PaycardEditor.Infrastructure.Repositories;

namespace PaycardEditor.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration, IOptions<AppSettings> settings)
    {
        serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

        serviceCollection.AddScoped<IPaycardRepository, PaycardRepository>();
        serviceCollection.AddScoped<IDatabaseRepository, DatabaseRepository>();

        serviceCollection.AddDbContext<PaycardEditorDbContext>(ctx => ctx.UseSqlServer(settings.Value.PaycardCS));

        return serviceCollection;
    }
}
