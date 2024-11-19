using PaycardEditor.Domain.Abstractions;
using PaycardEditor.Domain.Entities;
using PaycardEditor.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace PaycardEditor.Infrastructure;

internal class UnitOfWork : IUnitOfWork
{
    private readonly PaycardEditorDbContext _dbContext;
    //private readonly ILogger<UnitOfWork> _logger;

    public UnitOfWork(PaycardEditorDbContext dbContext)
    {
        _dbContext = dbContext;
        //_logger = logger;
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        UpdateAuditableEntities();
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    private void UpdateAuditableEntities()
    {
        var entries = _dbContext
            .ChangeTracker
            .Entries<Entity>();

        foreach (var entry in entries) 
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedAt = entry.Entity.UpdatedAt = DateTime.Now;
                //_logger.LogInformation($"{entry.Context.Model} has new object at {DateTime.Now}");
            }

            if (entry.State == EntityState.Modified)
            {
                entry.Entity.UpdatedAt = DateTime.Now;
                //_logger.LogInformation($"{entry.Context.Model} has updated object with {entry.Entity.Id} at {DateTime.Now}");
            }
        }
    }
}
