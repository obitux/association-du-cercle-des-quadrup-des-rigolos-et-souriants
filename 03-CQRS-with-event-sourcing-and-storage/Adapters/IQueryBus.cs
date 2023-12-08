namespace _03_CQRS_with_event_sourcing_and_storage.Adapters;

public interface IQueryBus
{
    TResponse Send<TQuery, TResponse>(TQuery query);
}