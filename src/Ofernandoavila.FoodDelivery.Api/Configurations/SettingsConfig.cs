using System.Diagnostics.CodeAnalysis;
using Ofernandoavila.FoodDelivery.Business.Models.Settings;

namespace Ofernandoavila.FoodDelivery.Api.Configurations;

[ExcludeFromCodeCoverage]
public static class SettingsConfig
{
    public static IServiceCollection AddAppCredentialsSettingsConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        var section = configuration.GetSection("AppCredentials");
        services.Configure<AppCredentials>(section);

        return services;
    }
    
    public static IServiceCollection AddAppSettingsConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        var section = configuration.GetSection("AppSettings");
        services.Configure<AppSettings>(section);

        return services;
    }
}
