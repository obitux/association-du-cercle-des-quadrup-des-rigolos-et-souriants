using _02_CQRS_with_event_sourcing.Adapters;

namespace _02_CQRS_with_event_sourcing.App.Secrétariat.AjouterUnMembre;

public class AjouterUnMembreHandler : ICommandHandler<AjouterUnMembreCommand>
{
    private readonly IEventBus _eventBus;

    public AjouterUnMembreHandler(
        IEventBus eventBus)
    {
        _eventBus = eventBus;
    }

    public async Task Handle(AjouterUnMembreCommand command, CancellationToken ct)
    {
        var unMembreAEtéAjoutéEvent = new UnMembreAEtéAjoutéEvent(command.Nom, command.Prénom, command.Email);
        await _eventBus.Send(unMembreAEtéAjoutéEvent, ct);
    }
}