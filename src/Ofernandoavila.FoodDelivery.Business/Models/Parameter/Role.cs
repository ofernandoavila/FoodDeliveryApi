using System;
using Ofernandoavila.FoodDelivery.Business.Models.AccessControl;
using Ofernandoavila.FoodDelivery.Business.Models.Validations.Parameter;

namespace Ofernandoavila.FoodDelivery.Business.Models.Parameter;

public class Role : Entity
{
    public string Description { get; set; }

    public Guid UserId { get; set; }
    public IEnumerable<User> Users { get; set; }

    public Role()
    {

    }

    public Role(Guid id, string description)
    {
        Id = id;
        Description = description;
        Activate();
    }

    public override bool IsValid()
    {
        ValidationResult = new RoleValidation().Validate(this);
        return ValidationResult.IsValid;
    }
}
