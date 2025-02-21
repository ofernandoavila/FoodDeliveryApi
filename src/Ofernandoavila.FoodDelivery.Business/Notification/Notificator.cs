using System;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Notification;
using Ofernandoavila.FoodDelivery.Business.Models.Settings;

namespace Ofernandoavila.FoodDelivery.Business.Notification;

public class Notificator : INotificator
{
    private readonly List<Models.Settings.Notification> _notifications;
    public Notificator()
    {
        _notifications = [];
    }
    public List<Models.Settings.Notification> GetNotifications()
    {
        return _notifications;
    }

    public void Handle(Models.Settings.Notification notification)
    {
        _notifications.Add(notification);
    }

    public bool HasNotification()
    {
        return _notifications.Count != 0;
    }
}
