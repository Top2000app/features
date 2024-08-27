using Microsoft.Extensions.DependencyInjection;
using Top2000.Features.Searching;
using Top2000.Features.SQLite.AllListingsOfEdition;

namespace Top2000.Features.SQLite;

public static class ConfigureServices
{
    public static IServiceCollection AddFeaturesWithSQLite(this IServiceCollection services)
    {
        return services
            .AddMediatR(config =>
            {
                config.RegisterServicesFromAssemblyContaining<TrackCountHolder>();
            })
            .AddSingleton<TrackCountHolder>()
            .AddSingleton<ISort, SortByTitle>()
            .AddSingleton<ISort, SortByArtist>()
            .AddSingleton<ISort, SortByRecordedYear>()
            .AddSingleton<IGroup, GroupByNothing>()
            .AddSingleton<IGroup, GroupByArtist>()
            .AddSingleton<IGroup, GroupByRecordedYear>()
            ;
    }
}
