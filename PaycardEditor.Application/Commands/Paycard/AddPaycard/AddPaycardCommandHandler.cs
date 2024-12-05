using AutoMapper;
using PaycardEditor.Applications.Configuration.Commands;
using PaycardEditor.Applications.Dtos;
using PaycardEditor.Domain.Abstractions;

namespace PaycardEditor.Applications.Commands.Paycard.AddPaycard;

public class AddPaycardCommandHandler : ICommandHandler<AddPaycardCommand, PaycardDto>
{
    private readonly IPaycardRepository _paycardRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public AddPaycardCommandHandler(IPaycardRepository paycardRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _paycardRepository = paycardRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task<PaycardDto> Handle(AddPaycardCommand request, CancellationToken cancellationToken)
    {
        var paycard = new Domain.Entities.Paycard
        {
            OwnerAccountNr = request.OwnerAccountNr,
            PIN = int.Parse(request.PIN),
            SerialNr = request.SerialNr,
            CardId = RandomString()
        };

        _paycardRepository.Add(paycard);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var paycardDto = _mapper.Map<PaycardDto>(paycard);

        return paycardDto;
    }

    private static string RandomString()
    {
        var random = new Random();

        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        return new string(Enumerable.Repeat(chars, 32)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
