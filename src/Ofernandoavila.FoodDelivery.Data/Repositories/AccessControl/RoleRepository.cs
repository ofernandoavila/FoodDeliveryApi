using System;
using Microsoft.EntityFrameworkCore;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories.Parameter;
using Ofernandoavila.FoodDelivery.Business.Models.Parameter;
using Ofernandoavila.FoodDelivery.Data.Context;

namespace Ofernandoavila.FoodDelivery.Data.Repositories.AccessControl;

public class RoleRepository(AppDbContext context) : Repository<Role>(context), IRoleRepository
{
    public override Task<Role> GetById(Guid id)
    {
        return Db.Roles
                    .AsNoTracking()
                    .FirstOrDefaultAsync( r => r.Id == id);
    }
}
