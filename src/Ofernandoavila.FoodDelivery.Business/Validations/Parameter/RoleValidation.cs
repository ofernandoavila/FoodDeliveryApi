using System;
using FluentValidation;
using Ofernandoavila.FoodDelivery.Business.Models.Parameter;

namespace Ofernandoavila.FoodDelivery.Business.Models.Validations.Parameter;

public class RoleValidation : AbstractValidator<Role>
{
    private const int DescriptionMaxLenght = 50;
    public static string DescriptionEmptyOrNullErrorMessage => "The field Description cannot be empty";
    public static string DescriptionLenghtErrorMessage => $"The field Description can only contain {DescriptionMaxLenght} characters.";

    public RoleValidation()
    {
        RuleFor(t => t.Description)
                .NotNull().WithMessage(DescriptionEmptyOrNullErrorMessage)
                .NotEmpty().WithMessage(DescriptionEmptyOrNullErrorMessage)
                .MaximumLength(DescriptionMaxLenght).WithMessage(DescriptionLenghtErrorMessage);
    }
}
