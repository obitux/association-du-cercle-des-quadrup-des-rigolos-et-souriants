using _01_CQRS_without_event_sourcing.Adapters;

namespace _01_CQRS_without_event_sourcing.App.Secrétariat.AjouterUnMembre;

public class AjouterUnMembreHandler : ICommandHandler<AjouterUnMembreCommand>
{
    private readonly IMembreRepository _membreRepository;

    public AjouterUnMembreHandler(IMembreRepository membreRepository)
    {
        _membreRepository = membreRepository;
    }

    public async Task Handle(AjouterUnMembreCommand command, CancellationToken ct)
    {
        await _membreRepository.Create(command.Nom, command.Prénom, command.Email);
    }
}