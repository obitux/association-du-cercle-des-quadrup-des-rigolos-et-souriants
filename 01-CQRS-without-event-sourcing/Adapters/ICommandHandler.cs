namespace _01_CQRS_without_event_sourcing.Adapters;

public interface ICommandHandler<in TCommand>
{
    void Handle(TCommand command);
}