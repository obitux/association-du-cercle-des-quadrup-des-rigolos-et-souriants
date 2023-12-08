namespace _02_CQRS_with_event_sourcing.Adapters;

public interface IEventBus
{
    void Send<TEvent>(TEvent ev);
}