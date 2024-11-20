using PaycardEditor.Applications.Configuration.Queries;
using PaycardEditor.Applications.Dtos;

namespace PaycardEditor.Applications.Queries.Paycard.GetPaycardsBySerialNr;

public record GetPaycardsBySerialNrQuery(string serialNr) : IQuery<IEnumerable<PaycardDto>>
{
}
