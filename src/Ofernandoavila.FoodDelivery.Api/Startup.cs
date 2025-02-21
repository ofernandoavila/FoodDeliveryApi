using System.Diagnostics.CodeAnalysis;
using Ofernandoavila.FoodDelivery.Api.Configurations;
using Ofernandoavila.FoodDelivery.Api.Configurations.Swagger;

namespace Ofernandoavila.FoodDelivery.Api;

[ExcludeFromCodeCoverage]
public class Startup(IConfiguration configuration) : IStartUp
{
    public IConfiguration Configuration { get; } = configuration;

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDatabase(Configuration);
        services.AddAppCredentialsSettingsConfiguration(Configuration);
        services.AddAppSettingsConfiguration(Configuration);
        services.AddJWTConfiguration(Configuration);
        services.AddAutoMapper(typeof(AutomapperConfig));
        services.AddLoggerConfig(Configuration);
        services.ApiBehaviourConfig();
        services.ApiVersioningConfig();
        services.ApiCorsConfig();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerConfig();
        services.ResolveDependencies();
    }

    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        app.MigrateDatabase();
        app.UseApiConfiguration(env);
        app.UseSwaggerConfig();
        app.UseLoggerConfiguration();
        app.UseEndPointsConfiguration();
    }
}
