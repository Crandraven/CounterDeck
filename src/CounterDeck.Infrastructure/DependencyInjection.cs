using CounterDeck.Application.Common.Interfaces.Authentication;
using CounterDeck.Application.Common.Interfaces.Persistence;
using CounterDeck.Infrastructure.Authentication;
using CounterDeck.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CounterDeck.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
