// using System.Collections.ObjectModel;
// using System.Collections.Specialized;

namespace _01_CQRS_without_event_sourcing.Adapters;

public abstract class CommandBus : ICommandBus
{
    public abstract CommandId Send<TCommand>(TCommand command);
}

// internal record CommandRecord(CommandId Id, object Command);

public class InMemoryCommandBus : CommandBus
{
    // private readonly ObservableCollection<CommandRecord> _commands = new();
    private readonly IServiceProvider _serviceProvider;

    public InMemoryCommandBus(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        // _commands.CollectionChanged += OnNewCommand;
    }

    public override CommandId Send<TCommand>(TCommand command)
    {
        var commandId = new CommandId(Guid.NewGuid().ToString());
        // _commands.Add(new CommandRecord(commandId, command));
        _serviceProvider.GetRequiredService<ICommandHandler<TCommand>>().Handle(command);
        return commandId;
    }

    // private void OnNewCommand(object? sender, NotifyCollectionChangedEventArgs e)
    // {
    //     if (e.NewItems == null) return;
    //     foreach (CommandRecord newItem in e.NewItems)
    //     {
    //         Console.WriteLine(newItem);
    //         _serviceProvider.GetRequiredService<ICommandHandler<>>().Handle(
    //             newItem.Command);
    //     }
    // }
}

public abstract class CommandBusDecorator : CommandBus
{
    private readonly ICommandBus _commandBus;

    protected CommandBusDecorator(ICommandBus commandBus)
    {
        _commandBus = commandBus;
    }

    // The Decorator delegates all work to the wrapped component.
    public override CommandId Send<TCommand>(TCommand command)
    {
        return _commandBus.Send(command);
    }
}

public class CommandBusLogger : CommandBusDecorator
{
    public CommandBusLogger(ICommandBus commandBus) : base(commandBus)
    {
    }

    public override CommandId Send<TCommand>(TCommand command)
    {
        // var commandId = base.Send(command);
        // Console.WriteLine($"Une commande a été reçue [{commandId.Id}] " + command);
        // return commandId;

        Console.WriteLine("Une commande a été reçue : " + command);
        return base.Send(command);
    }
}