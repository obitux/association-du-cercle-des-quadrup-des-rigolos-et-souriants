namespace _03_CQRS_with_event_sourcing_and_storage.App.Secrétariat.AjouterUnMembre;

public record UnMembreAEtéAjoutéEvent(string Nom, string Prénom, string Email);