namespace _02_CQRS_with_event_sourcing.Adapters;

public class InMemoryEventBus : IEventBus
{
    private readonly IServiceProvider _serviceProvider;

    public InMemoryEventBus(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void Send<TEvent>(TEvent ev)
    {
        var eventHandlers = _serviceProvider.GetServices<IEventHandler<TEvent>>();
        eventHandlers.ToList().ForEach(handler => handler.Handle(ev));
    }
}