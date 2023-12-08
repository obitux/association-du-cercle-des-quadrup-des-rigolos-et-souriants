using _03_CQRS_with_event_sourcing_and_storage.Adapters;
using _03_CQRS_with_event_sourcing_and_storage.App.Secrétariat;

namespace _03_CQRS_with_event_sourcing_and_storage.App;

public static class AppModule
{
    public static IServiceCollection RegisterAppModule(this IServiceCollection services)
    {
        services.AddSingleton<IEventStore>(sp => new InMemoryEventStore());
        services.AddScoped<IQueryBus>(sp => new InMemoryQueryBus(sp));
        services.AddScoped<ICommandBus>(sp => new InMemoryCommandBus(sp));
        services.AddScoped<IEventBus>(sp => new InMemoryEventBus(sp, sp.GetRequiredService<IEventStore>()));

        services.RegisterSecrétariatModule();

        return services;
    }
}