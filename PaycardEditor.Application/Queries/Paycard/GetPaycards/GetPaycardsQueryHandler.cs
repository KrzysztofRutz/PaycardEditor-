using AutoMapper;
using PaycardEditor.Applications.Configuration.Queries;
using PaycardEditor.Applications.Dtos;
using PaycardEditor.Domain.Abstractions;

namespace PaycardEditor.Applications.Queries.Paycard.GetPaycards;

public class GetPaycardsQueryHandler : IQueryHandler<GetPaycardsQuery, IEnumerable<PaycardDto>>
{
    private readonly IPaycardRepository _paycardRepository;
    private readonly IMapper _mapper;

    public GetPaycardsQueryHandler(IPaycardRepository paycardRepository, IMapper mapper)
    {
        _paycardRepository = paycardRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PaycardDto>> Handle(GetPaycardsQuery request, CancellationToken cancellationToken)
    {
        var paycards = await _paycardRepository.GetAllAsync(cancellationToken);

        var paycardsDto = _mapper.Map<IEnumerable<PaycardDto>>(paycards);

        return paycardsDto;
    }
}
