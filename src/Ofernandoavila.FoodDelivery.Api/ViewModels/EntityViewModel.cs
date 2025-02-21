using System.ComponentModel.DataAnnotations;

namespace Ofernandoavila.FoodDelivery.Api.ViewModels;

public class EntityViewModel
{
    [Key]
    public Guid Id { get; set; }
    public bool Active { get; set; } = true;

    public EntityViewModel()
    {
        Id = Guid.NewGuid();
    }
}
