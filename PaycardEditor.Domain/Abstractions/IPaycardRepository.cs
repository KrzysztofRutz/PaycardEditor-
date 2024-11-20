using PaycardEditor.Domain.Entities;

namespace PaycardEditor.Domain.Abstractions;

public interface IPaycardRepository
{
    Task<IEnumerable<Paycard>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Paycard> GetByIdAsync(int id);
    Task<IEnumerable<Paycard>> GetByOwnerAccountNrAsync(string ownerAccountNr, CancellationToken cancellationToken = default);
    Task<IEnumerable<Paycard>> GetBySerialNrAsync(string serialNr, CancellationToken cancellationToken = default);
    Task<Paycard> GetByCardIdAsync(string cardId);
    void Add(Paycard paycard);
    void Delete(Paycard paycard);
}
