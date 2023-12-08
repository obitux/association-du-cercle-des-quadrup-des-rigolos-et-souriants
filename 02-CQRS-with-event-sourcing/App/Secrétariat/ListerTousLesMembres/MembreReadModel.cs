namespace _02_CQRS_with_event_sourcing.App.Secrétariat.ListerTousLesMembres;

public record MembreReadModel(string Nom, string Prénom, string Email);