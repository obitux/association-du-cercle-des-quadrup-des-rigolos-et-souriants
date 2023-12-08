using _03_CQRS_with_event_sourcing_and_storage.Adapters;
using Microsoft.AspNetCore.Mvc;

namespace _03_CQRS_with_event_sourcing_and_storage.App.Secrétariat.AjouterUnMembre;

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
    public void Post([FromBody] AjouterUnMembreCommand command)
    {
        _commandBus.Send(command);
    }
}