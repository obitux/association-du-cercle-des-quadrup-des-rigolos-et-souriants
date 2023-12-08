namespace _02_CQRS_with_event_sourcing.Adapters;

public interface IEventBus
{
    Task Send<TEvent>(TEvent ev, CancellationToken ct);
}