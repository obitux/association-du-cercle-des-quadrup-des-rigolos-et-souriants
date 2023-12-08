using _02_CQRS_with_event_sourcing.Adapters;
using _02_CQRS_with_event_sourcing.App.Secrétariat.AjouterUnMembre;
using _02_CQRS_with_event_sourcing.App.Secrétariat.ListerTousLesMembres;

namespace _02_CQRS_with_event_sourcing.App.Secrétariat;

public static class SecrétariatModule
{
    public static IServiceCollection RegisterSecrétariatModule(this IServiceCollection services)
    {
        services.AddScoped<IQueryHandler<ListerLesMembresQuery, List<MembreReadModel>>>(sp =>
            new ListerLesMembresHandler(sp.GetRequiredService<IListeDesMembresRepository>()));

        services.AddScoped<ICommandHandler<AjouterUnMembreCommand>>(sp =>
            new AjouterUnMembreHandler(sp.GetRequiredService<IEventBus>()));

        services.AddScoped<IEventHandler<UnMembreAEtéAjoutéEvent>>(sp =>
            new UnMembreAEtéAjoutéHandler(sp.GetRequiredService<IListeDesMembresRepository>()));

        return services;
    }
}