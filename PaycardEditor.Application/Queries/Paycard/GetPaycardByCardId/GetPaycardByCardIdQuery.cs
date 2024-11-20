using PaycardEditor.Applications.Configuration.Queries;
using PaycardEditor.Applications.Dtos;

namespace PaycardEditor.Applications.Queries.Paycard.GetPaycardByCardId;

public record GetPaycardByCardIdQuery(string CardId) : IQuery<PaycardDto>
{
}
