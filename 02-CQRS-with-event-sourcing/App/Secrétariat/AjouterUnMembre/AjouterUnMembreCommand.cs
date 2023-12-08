namespace _02_CQRS_with_event_sourcing.App.Secrétariat.AjouterUnMembre;

public record AjouterUnMembreCommand(string Nom, string Prénom, string Email);