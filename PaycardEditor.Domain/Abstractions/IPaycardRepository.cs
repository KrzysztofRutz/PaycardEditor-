using PaycardEditor.Domain.Entities;

namespace PaycardEditor.Domain.Abstractions;

public interface IPaycardRepository
{
    Task<IEnumerable<Paycard>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Paycard> GetByIdAsync(int id);
    Task<Paycard> GetByOwnerAccountNrAsync(int ownerAccountNr);
    Task<Paycard> GetBySerialNrAsync(int serialNr);
    Task<Paycard> GetByCardIdAsync(string cardId);
    void Add(Paycard paycard);
    void Delete(Paycard paycard);
}
