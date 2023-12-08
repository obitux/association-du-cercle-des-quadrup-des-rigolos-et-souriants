namespace _02_CQRS_with_event_sourcing.Adapters;

internal interface IQueryHandler<in TQuery, out TResult>
{
    TResult Handle(TQuery query);
}