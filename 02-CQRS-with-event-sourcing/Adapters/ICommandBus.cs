namespace _02_CQRS_with_event_sourcing.Adapters;

public interface ICommandBus
{
    Task Send<TCommand>(TCommand command, CancellationToken ct);
}