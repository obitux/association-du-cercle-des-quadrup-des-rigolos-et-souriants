using _01_CQRS_without_event_sourcing.Adapters;

namespace _01_CQRS_without_event_sourcing.App.Secrétariat.ChangerLEmailDunMembre;

public class ChangerLEmailDUnMembreHandler : ICommandHandler<ChangerLEmailDUnMembreCommand>
{
    private readonly IMembreRepository _membreRepository;

    public ChangerLEmailDUnMembreHandler(IMembreRepository membreRepository)
    {
        _membreRepository = membreRepository;
    }

    public void Handle(ChangerLEmailDUnMembreCommand command)
    {
        _membreRepository.ChangeEmail(command.membreId, command.nouvelEmail);
    }
}