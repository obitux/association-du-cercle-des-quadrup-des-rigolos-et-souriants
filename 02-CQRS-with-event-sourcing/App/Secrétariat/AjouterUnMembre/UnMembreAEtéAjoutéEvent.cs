namespace _02_CQRS_with_event_sourcing.App.Secrétariat.AjouterUnMembre;

public record UnMembreAEtéAjoutéEvent(string Nom, string Prénom, string Email);