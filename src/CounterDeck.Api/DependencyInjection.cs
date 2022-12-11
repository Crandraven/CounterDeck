using CounterDeck.Api.Common.Errors;
using CounterDeck.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace CounterDeck.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, CounterDeckProblemDetailsFactory>();
        services.AddMappings();

        return services;
    }
}
