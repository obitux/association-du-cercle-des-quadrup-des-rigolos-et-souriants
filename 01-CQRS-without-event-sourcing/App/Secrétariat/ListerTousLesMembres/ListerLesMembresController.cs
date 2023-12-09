using _01_CQRS_without_event_sourcing.Adapters;
using Microsoft.AspNetCore.Mvc;

namespace _01_CQRS_without_event_sourcing.App.Secrétariat.ListerTousLesMembres;

[ApiController]
[Route("secretariat/lister-les-membres")]
public class ListerLesMembresController : ControllerBase
{
    private readonly IQueryBus _queryBus;

    public ListerLesMembresController(
        IQueryBus queryBus)
    {
        _queryBus = queryBus;
    }

    [HttpGet]
    public Task<List<MembreReadModel>> Get()
    {
        var query = new ListerLesMembresQuery();
        return Task.FromResult(_queryBus.Send<ListerLesMembresQuery, List<MembreReadModel>>(query));
    }
}