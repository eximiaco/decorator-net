using CSharpFunctionalExtensions;

namespace Eximia.Decorator.Domain;

public interface ICommandHandler<TCommand>
{
    Task<Result> HandleAsync(TCommand command);
}
