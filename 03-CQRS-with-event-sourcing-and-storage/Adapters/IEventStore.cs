namespace _03_CQRS_with_event_sourcing_and_storage.Adapters;

public interface IEventStore
{
    void Rewind(IEventBus eventBus);
    void StoreEvent<TEvent>(TEvent ev);
}