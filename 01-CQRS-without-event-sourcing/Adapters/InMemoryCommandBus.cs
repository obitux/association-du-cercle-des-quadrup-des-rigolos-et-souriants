namespace _01_CQRS_without_event_sourcing.Adapters;

public class InMemoryCommandBus : ICommandBus
{
    private readonly IServiceProvider _serviceProvider;

    public InMemoryCommandBus(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void Send<TCommand>(TCommand command)
    {
        _serviceProvider.GetRequiredService<ICommandHandler<TCommand>>().Handle(command);
    }
}