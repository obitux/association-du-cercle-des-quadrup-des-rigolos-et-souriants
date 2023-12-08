namespace _01_CQRS_without_event_sourcing.Adapters;

public interface IQueryBus
{
    Task<TResponse> Send<TQuery, TResponse>(TQuery query, CancellationToken ct);
}