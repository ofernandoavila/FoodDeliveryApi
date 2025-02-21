using System;
using System.Security.Claims;

namespace Ofernandoavila.FoodDelivery.Business.Interfaces.User;

public interface IUser
{
    string Name { get; }
    string GetUserEmail();
    bool IsAuthenticated();
    bool GetFirstAccess();
    bool IsInRole(string role);
    Guid GetUserId();
    IEnumerable<Claim> GetClaimsIdentity();
    string GetUserAgent();
    string GetUserRole();
    Task<string> GetUserToken();
}
