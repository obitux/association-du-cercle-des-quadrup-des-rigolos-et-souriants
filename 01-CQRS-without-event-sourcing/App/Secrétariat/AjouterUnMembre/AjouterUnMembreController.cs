using _01_CQRS_without_event_sourcing.Adapters;
using Microsoft.AspNetCore.Mvc;

namespace _01_CQRS_without_event_sourcing.App.Secrétariat.AjouterUnMembre;

[ApiController]
[Route("secretariat/ajouter-un-membre")]
public class AjouterUnMembreController : ControllerBase
{
    private readonly ICommandBus _commandBus;

    public AjouterUnMembreController(ICommandBus commandBus)
    {
        _commandBus = commandBus;
    }

    [HttpPost]
    public async Task Post(
        CancellationToken ct,
        [FromBody] AjouterUnMembreCommand command)
    {
        _commandBus.Send(command);
    }
}