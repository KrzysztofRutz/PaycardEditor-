using PaycardEditor.Applications.Configuration.Queries;
using PaycardEditor.Applications.Dtos;

namespace PaycardEditor.Applications.Queries.Paycard.GetPaycardsByOwnerAccountNr;

public record GetPaycardsByOwnerAccountNrQuery (string ownerAccountNr) : IQuery<IEnumerable<PaycardDto>>
{
}
