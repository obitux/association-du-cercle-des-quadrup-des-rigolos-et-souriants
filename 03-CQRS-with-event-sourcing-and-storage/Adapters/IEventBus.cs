namespace _03_CQRS_with_event_sourcing_and_storage.Adapters;

public interface IEventBus
{
    void Send<TEvent>(TEvent ev);
}