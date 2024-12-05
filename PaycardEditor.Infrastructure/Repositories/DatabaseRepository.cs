using Microsoft.EntityFrameworkCore;
using PaycardEditor.Domain.Abstractions;
using PaycardEditor.Infrastructure.Context;

namespace PaycardEditor.Infrastructure.Repositories;

internal class DatabaseRepository : IDatabaseRepository
{
    private readonly PaycardEditorDbContext _dbContext;

    public DatabaseRepository(PaycardEditorDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task UpdateAsync()
        => await _dbContext.Database.MigrateAsync();
}
