using System;
using Microsoft.AspNetCore.Mvc;

namespace Ofernandoavila.FoodDelivery.Api.Configurations;

public static class ApiConfig
{
    public static IServiceCollection ApiBehaviourConfig(this IServiceCollection services)
    {
        services.Configure<ApiBehaviorOptions>( options =>
                                                {
                                                    options.SuppressModelStateInvalidFilter = true;
                                                });

        return services;
    }
}
