namespace _02_CQRS_with_event_sourcing.App.Secrétariat.ListerTousLesMembres;

public class InMemoryListeDesListeDesMembresRepository : IListeDesMembresRepository
{
    private readonly List<MembreInRepository> _membres = new();

    public void Create(string nom, string prénom, string email)
    {
        var row = new MembreInRepository(nom, prénom, email);
        _membres.Add(row);
    }

    public List<MembreInRepository> List()
    {
        return _membres.ToList();
    }
}