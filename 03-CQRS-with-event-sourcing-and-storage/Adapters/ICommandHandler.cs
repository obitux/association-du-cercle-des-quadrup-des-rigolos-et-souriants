namespace _03_CQRS_with_event_sourcing_and_storage.Adapters;

public interface ICommandHandler<in TCommand>
{
    void Handle(TCommand command);
}