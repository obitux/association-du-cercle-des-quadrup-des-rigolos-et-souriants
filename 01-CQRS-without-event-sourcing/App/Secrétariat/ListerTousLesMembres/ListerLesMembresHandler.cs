using _01_CQRS_without_event_sourcing.Adapters;

namespace _01_CQRS_without_event_sourcing.App.Secrétariat.ListerTousLesMembres;

public class ListerLesMembresHandler : IQueryHandler<ListerLesMembresQuery, List<MembreReadModel>>
{
    private readonly IMembreRepository _membreRepository;

    public ListerLesMembresHandler(IMembreRepository inMemoryMembreRepository)
    {
        _membreRepository = inMemoryMembreRepository;
    }

    public async Task<List<MembreReadModel>> Handle(ListerLesMembresQuery query, CancellationToken ct)
    {
        var list = await _membreRepository.List();
        return list.ConvertAll(input => new MembreReadModel(input.Nom, input.Prénom, input.Email));
    }
}