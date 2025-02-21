using FluentValidation.Results;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Notification;
using Ofernandoavila.FoodDelivery.Business.Models;

namespace Ofernandoavila.FoodDelivery.Business.Services;

public abstract class BaseService
{
    private readonly INotificator _notificator;

    protected BaseService(INotificator notificator)
    {
        _notificator = notificator;
    }

    protected void Notificate(ValidationResult validationResult)
    {
        foreach(var error in validationResult.Errors)
            Notificate(error.ErrorMessage);
    }

    protected bool Notificate(string errorMessage, bool ret = false)
    {
        _notificator.Handle(new Models.Settings.Notification(errorMessage));
        return ret;
    }

    protected bool IsValid<TEntity>(TEntity entity) where TEntity : Entity
    {
        if(entity.IsValid()) return true;

        Notificate(entity.ValidationResult);

        return false;
    }
}
