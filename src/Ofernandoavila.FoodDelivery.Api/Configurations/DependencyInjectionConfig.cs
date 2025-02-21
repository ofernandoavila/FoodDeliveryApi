using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Options;
using Ofernandoavila.FoodDelivery.Api.Configurations.Swagger;
using Ofernandoavila.FoodDelivery.Api.Extensions;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Notification;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories.AccessControl;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories.Parameter;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Services.AccessControl;
using Ofernandoavila.FoodDelivery.Business.Interfaces.User;
using Ofernandoavila.FoodDelivery.Business.Models.AccessControl;
using Ofernandoavila.FoodDelivery.Business.Notification;
using Ofernandoavila.FoodDelivery.Business.Services.AccessControl;
using Ofernandoavila.FoodDelivery.Data.Context;
using Ofernandoavila.FoodDelivery.Data.Repositories;
using Ofernandoavila.FoodDelivery.Data.Repositories.AccessControl;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Ofernandoavila.FoodDelivery.Api.Configurations;

[ExcludeFromCodeCoverage]
public static class DependencyInjectionConfig
{
    public static IServiceCollection ResolveDependencies(this IServiceCollection services)
    {
        services.AddMemoryCache();
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddScoped<AppDbContext>();
        services.AddScoped<INotificator, Notificator>();
        services.AddScoped<IUser, AppUser>();
        services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
        services.AddScoped<IUnityOfWork, UnityOfWork>();

        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<ISessionRepository, SessionRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<ISessionService, SessionService>();
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
