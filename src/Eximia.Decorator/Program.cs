using Eximia.Decorator.Domain;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<PermissaoService>();
builder.Services.AddScoped<ICommandHandler<CriarPedidoCommand>, CriarPedidoCommandHandler>();
builder.Services.AddScoped<ICommandHandler<AtualizarPedidoCommand>, AtualizarPedidoCommandHandler>();

builder.Services.Decorate(typeof(ICommandHandler<>), typeof(PermissaoDecorator<>));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapPost("/", async (ICommandHandler<CriarPedidoCommand> handler) =>
{
    await handler.HandleAsync(new CriarPedidoCommand());
});

app.MapPut("/", async (ICommandHandler<AtualizarPedidoCommand> handler) =>
{
    await handler.HandleAsync(new AtualizarPedidoCommand());
});

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
