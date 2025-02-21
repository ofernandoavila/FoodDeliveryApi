using System;
using System.Diagnostics.CodeAnalysis;

namespace Ofernandoavila.FoodDelivery.Api.Extensions;

[ExcludeFromCodeCoverage]
public static class StartupExtensions
{
    public static WebApplicationBuilder UseStartup<TStartUp>(this WebApplicationBuilder webAppBuilder)
        where TStartUp : IStartUp
    {
        if(Activator.CreateInstance(typeof(TStartUp), webAppBuilder.Configuration) is not IStartUp startup)
            throw new ArgumentException("Startup.cs class invalid!");

        startup.ConfigureServices(webAppBuilder.Services);

        var app = webAppBuilder.Build();

        startup.Configure(app, app.Environment);

        app.Run();
        
        return webAppBuilder;
    }
}
