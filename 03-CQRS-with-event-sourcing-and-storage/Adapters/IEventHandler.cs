namespace _03_CQRS_with_event_sourcing_and_storage.Adapters;

public interface IEventHandler<in TEvent>
{
    void Handle(TEvent ev);
}