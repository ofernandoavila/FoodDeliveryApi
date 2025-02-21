using System;

namespace Ofernandoavila.FoodDelivery.Api.ViewModels.DTO;

public class AppInfo
{
    public AppInfo()
    {
        Name = "Ofernandoavila Food Delivery API";
        Version = "1.0";
    }

    public string Name { get; set; }
    public string Version { get; set; }
}
