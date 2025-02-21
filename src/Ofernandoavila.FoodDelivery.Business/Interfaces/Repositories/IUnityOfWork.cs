using System;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories.AccessControl;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories.Parameter;

namespace Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories;

public interface IUnityOfWork : IDisposable
{
    IUserRepository UserRepository { get; }
    ISessionRepository SessionRepository { get; }
    IRoleRepository RoleRepository { get; }

    Task<int> Complete();
}
