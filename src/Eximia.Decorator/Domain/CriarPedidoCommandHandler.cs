using CSharpFunctionalExtensions;

namespace Eximia.Decorator.Domain;

public record CriarPedidoCommand();

public class CriarPedidoCommandHandler : ICommandHandler<CriarPedidoCommand>
{
    public async Task<Result> HandleAsync(CriarPedidoCommand command)
    {
        return Result.Success();
    }
}