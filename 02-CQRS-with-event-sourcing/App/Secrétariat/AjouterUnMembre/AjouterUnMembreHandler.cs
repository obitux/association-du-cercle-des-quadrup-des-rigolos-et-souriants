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

    public void Handle(AjouterUnMembreCommand command)
    {
        var unMembreAEtéAjoutéEvent = new UnMembreAEtéAjoutéEvent(command.Nom, command.Prénom, command.Email);
        _eventBus.Send(unMembreAEtéAjoutéEvent);
    }
}