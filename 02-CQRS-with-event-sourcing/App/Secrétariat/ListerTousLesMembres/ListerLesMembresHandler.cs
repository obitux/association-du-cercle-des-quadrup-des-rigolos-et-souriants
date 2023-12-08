using _02_CQRS_with_event_sourcing.Adapters;

namespace _02_CQRS_with_event_sourcing.App.Secrétariat.ListerTousLesMembres;

public class ListerLesMembresHandler : IQueryHandler<ListerLesMembresQuery, List<MembreReadModel>>
{
    private readonly IListeDesMembresRepository _listeDesMembresRepository;

    public ListerLesMembresHandler(IListeDesMembresRepository inMemoryListeDesMembresRepository)
    {
        _listeDesMembresRepository = inMemoryListeDesMembresRepository;
    }

    public async Task<List<MembreReadModel>> Handle(ListerLesMembresQuery query, CancellationToken ct)
    {
        var list = await _listeDesMembresRepository.List();
        return list.ConvertAll(ToMembreReadModel);
    }

    private static MembreReadModel ToMembreReadModel(MembreInRepository input)
    {
        return new MembreReadModel(input.Nom, input.Prénom, input.Email);
    }
}