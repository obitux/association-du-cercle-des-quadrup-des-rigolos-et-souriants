namespace _02_CQRS_with_event_sourcing.Adapters;

public interface IQueryBus
{
    Task<TResponse> Send<TQuery, TResponse>(TQuery query, CancellationToken ct);
}