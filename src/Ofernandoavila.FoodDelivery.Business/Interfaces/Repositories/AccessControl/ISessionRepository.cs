using Ofernandoavila.FoodDelivery.Business.Models.AccessControl;

namespace Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories.AccessControl;

public interface ISessionRepository : IRepository<Session>
{
    Task<Session> GetByRefreshToken(string refreshToken, int expirationRefreshTokenMinutes);
}
