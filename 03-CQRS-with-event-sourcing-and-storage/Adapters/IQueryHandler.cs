namespace _03_CQRS_with_event_sourcing_and_storage.Adapters;

internal interface IQueryHandler<in TQuery, out TResult>
{
    TResult Handle(TQuery query);
}