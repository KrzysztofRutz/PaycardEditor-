using AutoMapper;
using PaycardEditor.Applications.Configuration.Queries;
using PaycardEditor.Applications.Dtos;
using PaycardEditor.Domain.Abstractions;

namespace PaycardEditor.Applications.Queries.Paycard.GetPaycardByCardId;

public class GetPaycardByCardIdQueryHandler : IQueryHandler<GetPaycardByCardIdQuery, PaycardDto>
{
    private readonly IPaycardRepository _paycardRepository;
    private readonly IMapper _mapper;

    public GetPaycardByCardIdQueryHandler(IPaycardRepository paycardRepository, IMapper mapper)
    {
        _paycardRepository = paycardRepository;
        _mapper = mapper;
    }

    public async Task<PaycardDto> Handle(GetPaycardByCardIdQuery request, CancellationToken cancellationToken)
    {
        var paycard = await _paycardRepository.GetByCardIdAsync(request.CardId);

        var paycardDto = _mapper.Map<PaycardDto>(paycard);

        return paycardDto;
    }
}
