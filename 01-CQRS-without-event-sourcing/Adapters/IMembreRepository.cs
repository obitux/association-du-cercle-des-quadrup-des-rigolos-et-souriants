namespace _01_CQRS_without_event_sourcing.Adapters;

public record MembreInRepository(string Nom, string Prénom, string Email);

public interface IMembreRepository
{
    public Task Create(string nom, string prénom, string email);
    public Task<List<MembreInRepository>> List();
}