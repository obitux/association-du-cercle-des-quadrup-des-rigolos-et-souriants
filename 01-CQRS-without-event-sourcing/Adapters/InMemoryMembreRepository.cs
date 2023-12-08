namespace _01_CQRS_without_event_sourcing.Adapters;

public class InMemoryMembreRepository : IMembreRepository
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