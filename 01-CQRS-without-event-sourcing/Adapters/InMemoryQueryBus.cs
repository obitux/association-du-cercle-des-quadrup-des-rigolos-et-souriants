namespace _01_CQRS_without_event_sourcing.Adapters;

public class InMemoryQueryBus : IQueryBus
{
    private readonly IServiceProvider _serviceProvider;

    public InMemoryQueryBus(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public Task<TResponse> Send<TQuery, TResponse>(TQuery query, CancellationToken ct)
    {
        return _serviceProvider.GetRequiredService<IQueryHandler<TQuery, TResponse>>().Handle(query, ct);
    }
}