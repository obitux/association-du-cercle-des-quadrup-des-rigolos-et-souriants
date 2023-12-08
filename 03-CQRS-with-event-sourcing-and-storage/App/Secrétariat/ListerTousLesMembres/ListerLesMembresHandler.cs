using _03_CQRS_with_event_sourcing_and_storage.Adapters;

namespace _03_CQRS_with_event_sourcing_and_storage.App.Secrétariat.ListerTousLesMembres;

public class ListerLesMembresHandler : IQueryHandler<ListerLesMembresQuery, List<MembreReadModel>>
{
    private readonly IListeDesMembresRepository _listeDesMembresRepository;

    public ListerLesMembresHandler(IListeDesMembresRepository inMemoryListeDesMembresRepository)
    {
        _listeDesMembresRepository = inMemoryListeDesMembresRepository;
    }

    public List<MembreReadModel> Handle(ListerLesMembresQuery query)
    {
        var list = _listeDesMembresRepository.List();
        return list.ConvertAll(ToMembreReadModel);
    }

    private static MembreReadModel ToMembreReadModel(MembreInRepository input)
    {
        return new MembreReadModel(input.Nom, input.Prénom, input.Email);
    }
}