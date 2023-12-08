using _01_CQRS_without_event_sourcing.Adapters;
using _01_CQRS_without_event_sourcing.App.Secrétariat.ListerTousLesMembres;

namespace _01_CQRS_without_event_sourcing.App.Secrétariat.AjouterUnMembre;

public class AjouterUnMembreHandler : ICommandHandler<AjouterUnMembreCommand>
{
    private readonly IMembreRepository _membreRepository;

    public AjouterUnMembreHandler(IMembreRepository membreRepository)
    {
        _membreRepository = membreRepository;
    }

    public void Handle(AjouterUnMembreCommand command)
    {
        _membreRepository.Create(command.Nom, command.Prénom, command.Email);
    }
}