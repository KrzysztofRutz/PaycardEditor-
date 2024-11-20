using AutoMapper;
using PaycardEditor.Applications.Configuration.Queries;
using PaycardEditor.Applications.Dtos;
using PaycardEditor.Domain.Abstractions;

namespace PaycardEditor.Applications.Queries.Paycard.GetPaycardsByOwnerAccountNr;

public class GetPaycardsByOwnerAccountNrQueryHandler : IQueryHandler<GetPaycardsByOwnerAccountNrQuery, IEnumerable<PaycardDto>>
{
    private readonly IPaycardRepository _paycardRepository;
    private readonly IMapper _mapper;

    public GetPaycardsByOwnerAccountNrQueryHandler(IPaycardRepository paycardRepository, IMapper mapper)
    {
        _paycardRepository = paycardRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PaycardDto>> Handle(GetPaycardsByOwnerAccountNrQuery request, CancellationToken cancellationToken)
    {
        var paycards = await _paycardRepository.GetByOwnerAccountNrAsync(request.ownerAccountNr, cancellationToken);

        var paycardsDto = _mapper.Map<IEnumerable<PaycardDto>>(paycards);

        return paycardsDto;
    }
}
