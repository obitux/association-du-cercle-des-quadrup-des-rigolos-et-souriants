namespace _02_CQRS_with_event_sourcing.Adapters;

public class InMemoryCommandBus : ICommandBus
{
    private readonly IServiceProvider _serviceProvider;

    public InMemoryCommandBus(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public Task Send<TCommand>(TCommand command, CancellationToken ct)
    {
        return _serviceProvider.GetRequiredService<ICommandHandler<TCommand>>().Handle(command, ct);
    }
}