namespace _02_CQRS_with_event_sourcing.Adapters;

internal interface IQueryHandler<in TQuery, TResult>
{
    Task<TResult> Handle(TQuery query, CancellationToken ct);
}