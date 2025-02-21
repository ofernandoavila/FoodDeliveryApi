namespace Ofernandoavila.FoodDelivery.Business.Interfaces.Notification;

public interface INotificator
{
    bool HasNotification();
    List<Models.Settings.Notification> GetNotifications();
    void Handle(Models.Settings.Notification notification);
}
