using PaycardEditor.Applications.Configuration.Queries;
using PaycardEditor.Applications.Dtos;

namespace PaycardEditor.Applications.Queries.Paycard.GetPaycardById;

public record GetPaycardByIdQuery(int id) : IQuery<PaycardDto>
{
}
