using PaycardEditor.Applications.Configuration.Commands;
using PaycardEditor.Domain.Abstractions;
using PaycardEditor.Domain.Exceptions;

namespace PaycardEditor.Applications.Commands.Paycard.RemovePaycard;

public class RemovePaycardCommandHandler : ICommandHandler<RemovePaycardCommand>
{
    private readonly IPaycardRepository _paycardRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RemovePaycardCommandHandler(IPaycardRepository paycardRepository, IUnitOfWork unitOfWork)
    {
        _paycardRepository = paycardRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemovePaycardCommand request, CancellationToken cancellationToken)
    {
        var paycard = await _paycardRepository.GetByIdAsync(request.id);

        if (paycard == null)
        {
            throw new PaycardNotFoundException(request.id);
        }

        _paycardRepository.Delete(paycard);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
