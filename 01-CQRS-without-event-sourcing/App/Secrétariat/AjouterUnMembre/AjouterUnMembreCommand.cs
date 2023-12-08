namespace _01_CQRS_without_event_sourcing.App.Secrétariat.AjouterUnMembre;

public record AjouterUnMembreCommand(string Nom, string Prénom, string Email);