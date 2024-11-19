using MediatR;

namespace PaycardEditor.Applications.Configuration.Commands;

public interface ICommand : IRequest
{
}

public interface ICommand<out TResponse> : IRequest<TResponse> 
{
}
