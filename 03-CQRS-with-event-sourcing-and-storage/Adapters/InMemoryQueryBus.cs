namespace _03_CQRS_with_event_sourcing_and_storage.Adapters;

public class InMemoryQueryBus : IQueryBus
{
    private readonly IServiceProvider _serviceProvider;

    public InMemoryQueryBus(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public TResponse Send<TQuery, TResponse>(TQuery query)
    {
        return _serviceProvider.GetRequiredService<IQueryHandler<TQuery, TResponse>>().Handle(query);
    }
}