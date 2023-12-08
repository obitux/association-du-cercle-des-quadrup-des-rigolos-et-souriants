namespace _03_CQRS_with_event_sourcing_and_storage.Adapters;

public class InMemoryEventStore : IEventStore
{
    private readonly List<object> _store = new();

    public void Rewind(IEventBus eventBus)
    {
        _store.ForEach(eventBus.Send);
    }

    public void StoreEvent<TEvent>(TEvent ev)
    {
        _store.Add(ev);
    }
}