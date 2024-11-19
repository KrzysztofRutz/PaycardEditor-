using Microsoft.EntityFrameworkCore;
using PaycardEditor.Domain.Abstractions;
using PaycardEditor.Domain.Entities;
using PaycardEditor.Infrastructure.Context;

namespace PaycardEditor.Infrastructure.Repositories;

internal class PaycardRepository : IPaycardRepository
{
    private readonly PaycardEditorDbContext _dbContext;

    public PaycardRepository(PaycardEditorDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Paycard> GetByCardIdAsync(string cardId)
        => await _dbContext.Paycards.FirstAsync(x => x.CardId == cardId);

    public async Task<Paycard> GetByOwnerAccountNrAsync(int ownerAccountNr)
        => await _dbContext.Paycards.FirstAsync(x => x.OwnerAccountNr == ownerAccountNr);

    public async Task<Paycard> GetBySerialNrAsync(int serialNr)
        => await _dbContext.Paycards.FirstAsync(x => x.SerialNr == serialNr);

    public void Add(Paycard paycard)
        => _dbContext.Paycards.Add(paycard);

    public void Delete(Paycard paycard)
        => _dbContext?.Paycards.Remove(paycard);

    public async Task<Paycard> GetByIdAsync(int id)
        => await _dbContext.Paycards.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<Paycard>> GetAllAsync(CancellationToken cancellationToken = default)
        => await _dbContext.Paycards.AsNoTracking().ToListAsync(cancellationToken);
}
