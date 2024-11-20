using AutoMapper;
using PaycardEditor.Applications.Configuration.Queries;
using PaycardEditor.Applications.Dtos;
using PaycardEditor.Domain.Abstractions;

namespace PaycardEditor.Applications.Queries.Paycard.GetPaycardsBySerialNr;

public class GetPaycardsBySerialNrQueryHandler : IQueryHandler<GetPaycardsBySerialNrQuery, IEnumerable<PaycardDto>>
{
    private readonly IPaycardRepository _paycardRepository;
    private readonly IMapper _mapper;

    public GetPaycardsBySerialNrQueryHandler(IPaycardRepository paycardRepository, IMapper mapper)
    {
        _paycardRepository = paycardRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PaycardDto>> Handle(GetPaycardsBySerialNrQuery request, CancellationToken cancellationToken)
    {
        var paycards = await _paycardRepository.GetBySerialNrAsync(request.serialNr, cancellationToken);

        var paycardsDto = _mapper.Map<IEnumerable<PaycardDto>>(paycards);

        return paycardsDto;
    }
}
