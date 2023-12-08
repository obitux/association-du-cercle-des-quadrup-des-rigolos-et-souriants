namespace _01_CQRS_without_event_sourcing.Adapters;

internal interface IQueryHandler<in TQuery, out TResult>
{
    TResult Handle(TQuery query);
}