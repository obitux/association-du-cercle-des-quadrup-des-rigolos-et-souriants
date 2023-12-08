namespace _02_CQRS_with_event_sourcing.Adapters;

public class InMemoryEventBus : IEventBus
{
    private readonly IServiceProvider _serviceProvider;

    public InMemoryEventBus(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task Send<TEvent>(TEvent ev, CancellationToken ct)
    {
        var eventHandlers = _serviceProvider.GetServices<IEventHandler<TEvent>>();
        // FIXME : Do not await ? Do not run in seq ?
        foreach (var handler in eventHandlers) await handler.Handle(ev, ct);
    }
}