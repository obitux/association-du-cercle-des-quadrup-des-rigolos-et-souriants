using _03_CQRS_with_event_sourcing_and_storage.Adapters;
using _03_CQRS_with_event_sourcing_and_storage.App.Secrétariat.AjouterUnMembre;
using _03_CQRS_with_event_sourcing_and_storage.App.Secrétariat.ListerTousLesMembres;

namespace _03_CQRS_with_event_sourcing_and_storage.App.Secrétariat;

public static class SecrétariatModule
{
    public static IServiceCollection RegisterSecrétariatModule(this IServiceCollection services)
    {
        services.AddSingleton<IListeDesMembresRepository>(sp => new InMemoryListeDesMembresRepository());

        services.AddScoped<IQueryHandler<ListerLesMembresQuery, List<MembreReadModel>>>(sp =>
            new ListerLesMembresHandler(sp.GetRequiredService<IListeDesMembresRepository>()));

        services.AddScoped<ICommandHandler<AjouterUnMembreCommand>>(sp =>
            new AjouterUnMembreHandler(sp.GetRequiredService<IEventBus>()));

        services.AddScoped<IEventHandler<UnMembreAEtéAjoutéEvent>>(sp =>
            new UnMembreAEtéAjoutéHandler(sp.GetRequiredService<IListeDesMembresRepository>()));

        return services;
    }
}