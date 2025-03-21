using CSharpFunctionalExtensions;

namespace Eximia.Decorator.Domain;

public record AtualizarPedidoCommand();

public class AtualizarPedidoCommandHandler : ICommandHandler<AtualizarPedidoCommand>
{
    public async Task<Result> HandleAsync(AtualizarPedidoCommand command)
    {
        return Result.Success();
    }
}