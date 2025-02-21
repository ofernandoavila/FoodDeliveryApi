using System;
using System.Diagnostics.CodeAnalysis;

namespace Ofernandoavila.FoodDelivery.Business.Models.Settings;

[ExcludeFromCodeCoverage]
public class Notification(string message)
{
    public string Message { get; } = message;
}
