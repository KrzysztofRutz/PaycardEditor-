using MediatR;

namespace PaycardEditor.Applications.Configuration.Queries;

public interface IQuery<out TResult> : IRequest<TResult>
{
}
