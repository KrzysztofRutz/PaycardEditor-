using AutoMapper;
using PaycardEditor.Applications.Configuration.Queries;
using PaycardEditor.Applications.Dtos;
using PaycardEditor.Domain.Abstractions;
using PaycardEditor.Domain.Exceptions;

namespace PaycardEditor.Applications.Queries.Paycard.GetPaycardById;

public class GetPaycardByIdQueryHandler : IQueryHandler<GetPaycardByIdQuery, PaycardDto>
{
    private readonly IPaycardRepository _paycardRepository;
    private readonly IMapper _mapper;

    public GetPaycardByIdQueryHandler(IPaycardRepository paycardRepository, IMapper mapper)
    {
        _paycardRepository = paycardRepository;
        _mapper = mapper;
    }

    public async Task<PaycardDto> Handle(GetPaycardByIdQuery request, CancellationToken cancellationToken)
    {
        var paycard = await _paycardRepository.GetByIdAsync(request.id);

        if (paycard == null)
        {
            throw new PaycardNotFoundException(request.id);
        }

        var paycardDto = _mapper.Map<PaycardDto>(paycard);

        return paycardDto;
    }
}
