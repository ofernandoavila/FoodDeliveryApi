using System;
using System.ComponentModel.DataAnnotations;
using Ofernandoavila.FoodDelivery.Api.Extensions;

namespace Ofernandoavila.FoodDelivery.Api.ViewModels.AccessControl;

public class UserCreateViewModel : EntityViewModel
{
    [Required(ErrorMessage = "This field '{0}' is required")]
    public string Email { get; set; }

    [Required(ErrorMessage = "This field '{0}' is required")]
    public string Name { get; set; }

    [NotEmpty(ErrorMessage = "This field '{0}' is required")]
    public string RoleId { get; set; }
}
