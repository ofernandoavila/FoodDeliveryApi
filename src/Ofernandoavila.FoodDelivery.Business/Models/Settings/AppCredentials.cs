using System;

namespace Ofernandoavila.FoodDelivery.Business.Models.Settings;

public class AppCredentials
{
    public string AppUser { get; set; }
    public string AppPassword { get; set; }

    public AppCredentials()
    {

    }

    public AppCredentials(string appUser, string appPassword)
    {
        AppUser = appUser;
        AppPassword = appPassword;
    }
}
