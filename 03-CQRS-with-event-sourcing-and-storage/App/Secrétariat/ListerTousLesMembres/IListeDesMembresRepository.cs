namespace _03_CQRS_with_event_sourcing_and_storage.App.Secrétariat.ListerTousLesMembres;

public record MembreInRepository(string Nom, string Prénom, string Email);

public interface IListeDesMembresRepository
{
    public void Create(string nom, string prénom, string email);
    public List<MembreInRepository> List();
}