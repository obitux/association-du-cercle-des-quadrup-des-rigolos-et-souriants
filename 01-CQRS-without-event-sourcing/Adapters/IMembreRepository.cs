namespace _01_CQRS_without_event_sourcing.Adapters;

public record MembreInRepository(string Nom, string Prénom, string Email);

public interface IMembreRepository
{
    public void Create(string nom, string prénom, string email);
    public List<MembreInRepository> List();
}