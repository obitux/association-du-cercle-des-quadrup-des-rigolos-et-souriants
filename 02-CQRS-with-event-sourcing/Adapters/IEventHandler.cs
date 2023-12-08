namespace _02_CQRS_with_event_sourcing.Adapters;

public interface IEventHandler<in TEvent>
{
    void Handle(TEvent ev);
}