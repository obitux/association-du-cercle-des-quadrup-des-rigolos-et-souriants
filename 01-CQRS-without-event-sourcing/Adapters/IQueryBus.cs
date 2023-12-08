namespace _01_CQRS_without_event_sourcing.Adapters;

public interface IQueryBus
{
    TResponse Send<TQuery, TResponse>(TQuery query);
}