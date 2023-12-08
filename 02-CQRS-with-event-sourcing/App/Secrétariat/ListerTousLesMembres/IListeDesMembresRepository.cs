namespace _02_CQRS_with_event_sourcing.App.Secrétariat.ListerTousLesMembres;

public record MembreInRepository(string Nom, string Prénom, string Email);

public interface IListeDesMembresRepository
{
    public void Create(string nom, string prénom, string email);
    public List<MembreInRepository> List();
}