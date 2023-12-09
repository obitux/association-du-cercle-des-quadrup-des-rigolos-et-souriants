namespace _03_CQRS_with_event_sourcing_and_storage.Adapters;

public class InMemoryEventBus : IEventBus
{
    private readonly IEventStore _eventStore;
    private readonly IServiceProvider _serviceProvider;

    public InMemoryEventBus(IServiceProvider serviceProvider, IEventStore eventStore)
    {
        _serviceProvider = serviceProvider;
        _eventStore = eventStore;
    }

    public void Send<TEvent>(TEvent ev)
    {
        // TODO: we could use the Pattern decorator to store received Events
        _eventStore.StoreEvent(ev);

        var eventHandlers = _serviceProvider.GetServices<IEventHandler<TEvent>>();
        eventHandlers.ToList().ForEach(handler => handler.Handle(ev));
    }
}