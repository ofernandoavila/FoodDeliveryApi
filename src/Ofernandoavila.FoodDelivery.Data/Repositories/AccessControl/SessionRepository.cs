using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories.AccessControl;
using Ofernandoavila.FoodDelivery.Business.Models.AccessControl;
using Ofernandoavila.FoodDelivery.Data.Context;

namespace Ofernandoavila.FoodDelivery.Data.Repositories.AccessControl;

public class SessionRepository(AppDbContext context) : Repository<Session>(context), ISessionRepository
{
    public override async Task<Session> GetById(Guid id)
    {
        return await Db.Session
                        .AsNoTracking()
                        .FirstOrDefaultAsync( s => s.Id == id);
    }

    public async Task<Session> GetByRefreshToken(string refreshToken, int expirationRefreshTokenMinutes)
    {
        return await Db.Session
                        .AsNoTracking()
                        .FirstOrDefaultAsync( s => s.RefreshToken == refreshToken &&
                                                    s.ExpirationTime >= DateTime.UtcNow.AddMinutes(-expirationRefreshTokenMinutes));
    }
}
