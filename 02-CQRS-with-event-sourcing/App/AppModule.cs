using _02_CQRS_with_event_sourcing.Adapters;
using _02_CQRS_with_event_sourcing.App.Secrétariat;
using _02_CQRS_with_event_sourcing.App.Secrétariat.ListerTousLesMembres;

namespace _02_CQRS_with_event_sourcing.App;

public static class AppModule
{
    public static IServiceCollection RegisterAppModule(this IServiceCollection services)
    {
        services.AddSingleton<IListeDesMembresRepository>(sp => new InMemoryListeDesListeDesMembresRepository());

        services.AddScoped<IQueryBus>(sp => new InMemoryQueryBus(sp));
        services.AddScoped<ICommandBus>(sp => new InMemoryCommandBus(sp));
        services.AddScoped<IEventBus>(sp => new InMemoryEventBus(sp));

        services.RegisterSecrétariatModule();

        return services;
    }
}