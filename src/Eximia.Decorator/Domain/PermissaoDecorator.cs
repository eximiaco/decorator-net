using CSharpFunctionalExtensions;

namespace Eximia.Decorator.Domain;

public class PermissaoDecorator<TCommand>(PermissaoService permissaoService, ICommandHandler<TCommand> handler) : ICommandHandler<TCommand>
{
    public async Task<Result> HandleAsync(TCommand command)
    {
        if (!await permissaoService.PodeExecutarAsync())
            return Result.Failure("Sem permissão para executar o comando.");
        return await handler.HandleAsync(command);
    }
}
