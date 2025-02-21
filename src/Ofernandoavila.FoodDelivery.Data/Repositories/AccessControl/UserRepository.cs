using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories.AccessControl;
using Ofernandoavila.FoodDelivery.Business.Models.AccessControl;
using Ofernandoavila.FoodDelivery.Data.Context;
using Ofernandoavila.FoodDelivery.Data.Extensions;

namespace Ofernandoavila.FoodDelivery.Data.Repositories.AccessControl;

public class UserRepository(AppDbContext context) : Repository<User>(context), IUserRepository
{
    public override async Task<IEnumerable<User>> GetAll(int pageNumber, int pageSize, Expression<Func<User, bool>> predicate, Expression<Func<User, object>> orderBy, bool desc = false)
    {
        var list = await Db.Users
                            .Include( u => u.Role)
                            .Where(predicate)
                            .OrderByCustom(orderBy, desc)
                            .Skip((pageNumber - 1) * pageSize)
                            .Take(pageSize)
                            .AsNoTracking()
                            .ToListAsync();

        return list;
    }

    public override async Task<User> GetById(Guid id)
    {
        return await Db.Users
                        .Include( u => u.Role)
                        .AsNoTracking()
                        .FirstOrDefaultAsync(u => u.Id == id);
    }

    public override Task<int> Add(User entity)
    {
        return base.Add(entity);
    }

    public async Task<User> GetUserByEmailAndPassword(string email, string password)
    {
        return await Db.Users
                        .Include( u => u.Role )
                        .AsNoTracking()
                        .FirstOrDefaultAsync( u => u.Active &&
                                                    u.Email.Equals(email) &&
                                                    u.Password.ToUpper().Equals(password.ToUpper()));
    }

    public async Task<User> GetUserByEmail(string email)
    {
        return await Db.Users
                        .Include( u => u.Email )
                        .AsNoTracking()
                        .FirstOrDefaultAsync( u => u.Active &&
                                                    u.Email.Equals(email));
    }
}
