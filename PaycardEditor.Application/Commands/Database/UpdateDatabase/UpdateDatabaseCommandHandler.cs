using PaycardEditor.Applications.Configuration.Commands;
using PaycardEditor.Domain.Abstractions;

namespace PaycardEditor.Applications.Commands.Database.UpdateDatabase;

public class UpdateDatabaseCommandHandler : ICommandHandler<UpdateDatabaseCommand>
{
    private readonly IDatabaseRepository _databaseRepository;

    public UpdateDatabaseCommandHandler(IDatabaseRepository databaseRepository)
    {
        _databaseRepository = databaseRepository;
    }

    public async Task Handle(UpdateDatabaseCommand request, CancellationToken cancellationToken)
        => await _databaseRepository.UpdateAsync();
}
