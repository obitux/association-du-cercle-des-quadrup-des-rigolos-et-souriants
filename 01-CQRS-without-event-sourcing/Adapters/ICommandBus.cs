namespace _01_CQRS_without_event_sourcing.Adapters;

public interface ICommandBus
{
    Task Send<TCommand>(TCommand command, CancellationToken ct);
}