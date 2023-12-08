namespace _02_CQRS_with_event_sourcing.Adapters;

public interface ICommandBus
{
    void Send<TCommand>(TCommand command);
}