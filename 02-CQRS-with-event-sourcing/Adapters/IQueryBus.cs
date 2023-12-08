namespace _02_CQRS_with_event_sourcing.Adapters;

public interface IQueryBus
{
    TResponse Send<TQuery, TResponse>(TQuery query);
}