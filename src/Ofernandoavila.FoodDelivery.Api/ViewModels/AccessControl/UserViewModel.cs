using System;
using Ofernandoavila.FoodDelivery.Api.ViewModels.Parameter;

namespace Ofernandoavila.FoodDelivery.Api.ViewModels.AccessControl;

public class UserViewModel : EntityViewModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool FirstAccesss { get; set; }
    public DateTime CreatedAt { get; set; }
    public RoleViewModel Role { get; set; }
}
