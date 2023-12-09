namespace _01_CQRS_without_event_sourcing.Adapters;

public record CommandId(string Id);

public interface ICommandBus
{
    CommandId Send<TCommand>(TCommand command);
}