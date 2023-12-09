using _01_CQRS_without_event_sourcing.Adapters;
using Microsoft.AspNetCore.Mvc;

namespace _01_CQRS_without_event_sourcing.App.Secrétariat.ChangerLEmailDunMembre;

[ApiController]
[Route("secretariat/changer-l-email-d-un-membre")]
public class ChangerLEmailDunMembreController : ControllerBase
{
    private readonly ICommandBus _commandBus;

    public ChangerLEmailDunMembreController(
        ICommandBus commandBus)
    {
        _commandBus = commandBus;
    }

    [HttpPost]
    public CommandId Post([FromBody] ChangerLEmailDUnMembreCommand command)
    {
        return _commandBus.Send(command);
    }
}