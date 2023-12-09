namespace _01_CQRS_without_event_sourcing.App.Secrétariat.ChangerLEmailDunMembre;

public record ChangerLEmailDUnMembreCommand(string membreId, string nouvelEmail);