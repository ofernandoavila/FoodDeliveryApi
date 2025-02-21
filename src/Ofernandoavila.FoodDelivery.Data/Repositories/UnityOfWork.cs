using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories.AccessControl;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories.Parameter;
using Ofernandoavila.FoodDelivery.Data.Context;
using Ofernandoavila.FoodDelivery.Data.Repositories.AccessControl;

namespace Ofernandoavila.FoodDelivery.Data.Repositories;

public class UnityOfWork(AppDbContext dbContext, IMemoryCache memoryCache) : IUnityOfWork
{
    private readonly AppDbContext _dbContext = dbContext;
    private readonly IMemoryCache _memoryCache = memoryCache;

    private IUserRepository _userRepository;
    public IUserRepository UserRepository { get => _userRepository ??= new UserRepository(_dbContext); }
    private ISessionRepository _sessionRepository;
    public ISessionRepository SessionRepository { get => _sessionRepository ??= new SessionRepository(_dbContext);  }
    private IRoleRepository _roleRepository;
    public IRoleRepository RoleRepository { get => _roleRepository ??= new RoleRepository(_dbContext); }

    public async Task<int> Complete()
    {
        var complete = 0;

        var strategy = _dbContext.Database.CreateExecutionStrategy();

        await strategy.ExecuteAsync(async () =>
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            
            complete = await _dbContext.SaveChangesAsync();

            transaction.Commit();
        });

        return complete;
    }

    public void Dispose()
    {
        _dbContext?.Dispose();
        GC.SuppressFinalize(this);
    }
}
