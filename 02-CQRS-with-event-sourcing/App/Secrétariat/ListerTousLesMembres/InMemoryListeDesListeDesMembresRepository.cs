namespace _02_CQRS_with_event_sourcing.App.Secrétariat.ListerTousLesMembres;

public class InMemoryListeDesListeDesMembresRepository : IListeDesMembresRepository
{
    private readonly List<MembreInRepository> _membres = new();

    public Task Create(string nom, string prénom, string email)
    {
        var row = new MembreInRepository(nom, prénom, email);
        _membres.Add(row);
        return Task.CompletedTask;
    }

    public Task<List<MembreInRepository>> List()
    {
        return Task.FromResult(_membres.ToList());
    }
}