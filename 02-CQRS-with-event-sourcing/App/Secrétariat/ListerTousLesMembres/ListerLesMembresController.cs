using _02_CQRS_with_event_sourcing.Adapters;
using Microsoft.AspNetCore.Mvc;

namespace _02_CQRS_with_event_sourcing.App.Secrétariat.ListerTousLesMembres;

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
    public async Task<List<MembreReadModel>> Get(CancellationToken ct)
    {
        var query = new ListerLesMembresQuery();
        return await _queryBus.Send<ListerLesMembresQuery, List<MembreReadModel>>(query, ct);
    }
}