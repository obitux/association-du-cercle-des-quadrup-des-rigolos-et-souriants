using _01_CQRS_without_event_sourcing.Adapters;

namespace _01_CQRS_without_event_sourcing.App.Secrétariat.ListerTousLesMembres;

public class ListerLesMembresHandler : IQueryHandler<ListerLesMembresQuery, List<MembreReadModel>>
{
    private readonly IMembreRepository _membreRepository;

    public ListerLesMembresHandler(IMembreRepository inMemoryMembreRepository)
    {
        _membreRepository = inMemoryMembreRepository;
    }

    public List<MembreReadModel> Handle(ListerLesMembresQuery query)
    {
        var list = _membreRepository.List();
        return list.ConvertAll(input => new MembreReadModel(input.Id, input.Nom, input.Prénom, input.Email));
    }
}