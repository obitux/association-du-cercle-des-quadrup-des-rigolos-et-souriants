namespace _03_CQRS_with_event_sourcing_and_storage.Adapters;

public interface ICommandBus
{
    void Send<TCommand>(TCommand command);
}