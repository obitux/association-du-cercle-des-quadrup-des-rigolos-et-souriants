using _02_CQRS_with_event_sourcing.Adapters;
using _02_CQRS_with_event_sourcing.App.Secrétariat.AjouterUnMembre;

namespace _02_CQRS_with_event_sourcing.App.Secrétariat.ListerTousLesMembres;

public class UnMembreAEtéAjoutéHandler : IEventHandler<UnMembreAEtéAjoutéEvent>
{
    private readonly IListeDesMembresRepository _listeDesMembresRepository;

    public UnMembreAEtéAjoutéHandler(IListeDesMembresRepository listeDesMembresRepository)
    {
        _listeDesMembresRepository = listeDesMembresRepository;
    }

    public async Task Handle(UnMembreAEtéAjoutéEvent ev, CancellationToken ct)
    {
        await _listeDesMembresRepository.Create(ev.Nom, ev.Prénom, ev.Email);
    }
}