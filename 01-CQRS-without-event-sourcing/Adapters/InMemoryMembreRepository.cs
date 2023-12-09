namespace _01_CQRS_without_event_sourcing.Adapters;

public class InMemoryMembreRepository : IMembreRepository
{
    private readonly List<MembreInRepository> _membres = new();

    public List<MembreInRepository> List()
    {
        return _membres.ToList();
    }

    public void ChangeEmail(string idDuMembre, string nouvelEmail)
    {
        var index = _membres.FindIndex(membre => membre.Id == idDuMembre);
        if (index < 0) throw new Exception($"Le membre [{idDuMembre}] n'a pas été trouvé en DB.");
        _membres[index] = new MembreInRepository(
            _membres[index].Id,
            _membres[index].Nom,
            _membres[index].Prénom,
            nouvelEmail);
    }

    public void Create(string nom, string prénom, string email)
    {
        var uuid = Guid.NewGuid().ToString();
        var nouveauMembre = new MembreInRepository(uuid, nom, prénom, email);
        _membres.Add(nouveauMembre);
    }
}