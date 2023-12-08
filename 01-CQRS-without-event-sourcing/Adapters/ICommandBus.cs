namespace _01_CQRS_without_event_sourcing.Adapters;

public interface ICommandBus
{
    void Send<TCommand>(TCommand command);
}