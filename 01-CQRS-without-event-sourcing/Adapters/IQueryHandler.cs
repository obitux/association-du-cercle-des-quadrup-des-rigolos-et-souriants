namespace _01_CQRS_without_event_sourcing.Adapters;

internal interface IQueryHandler<in TQuery, TResult>
{
    Task<TResult> Handle(TQuery query, CancellationToken ct);
}