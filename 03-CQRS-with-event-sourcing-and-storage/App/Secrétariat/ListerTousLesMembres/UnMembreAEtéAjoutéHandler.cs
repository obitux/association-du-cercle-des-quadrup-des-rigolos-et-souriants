using _03_CQRS_with_event_sourcing_and_storage.Adapters;
using _03_CQRS_with_event_sourcing_and_storage.App.Secrétariat.AjouterUnMembre;

namespace _03_CQRS_with_event_sourcing_and_storage.App.Secrétariat.ListerTousLesMembres;

public class UnMembreAEtéAjoutéHandler : IEventHandler<UnMembreAEtéAjoutéEvent>
{
    private readonly IListeDesMembresRepository _listeDesMembresRepository;

    public UnMembreAEtéAjoutéHandler(IListeDesMembresRepository listeDesMembresRepository)
    {
        _listeDesMembresRepository = listeDesMembresRepository;
    }

    public void Handle(UnMembreAEtéAjoutéEvent ev)
    {
        _listeDesMembresRepository.Create(ev.Nom, ev.Prénom, ev.Email);
    }
}