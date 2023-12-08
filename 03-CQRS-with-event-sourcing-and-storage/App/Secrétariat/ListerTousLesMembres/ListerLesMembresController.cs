using _03_CQRS_with_event_sourcing_and_storage.Adapters;
using Microsoft.AspNetCore.Mvc;

namespace _03_CQRS_with_event_sourcing_and_storage.App.Secrétariat.ListerTousLesMembres;

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