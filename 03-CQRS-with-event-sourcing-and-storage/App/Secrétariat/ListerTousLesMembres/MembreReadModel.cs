namespace _03_CQRS_with_event_sourcing_and_storage.App.Secrétariat.ListerTousLesMembres;

public record MembreReadModel(string Nom, string Prénom, string Email);