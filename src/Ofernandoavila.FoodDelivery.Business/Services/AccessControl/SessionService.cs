using System;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Notification;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Repositories;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Services.AccessControl;
using Ofernandoavila.FoodDelivery.Business.Models.AccessControl;

namespace Ofernandoavila.FoodDelivery.Business.Services.AccessControl;

public class SessionService(IUnityOfWork unityOfWork, INotificator notificator) : BaseService(notificator), ISessionService
{
    private readonly IUnityOfWork _unitOfWork = unityOfWork;
    public async Task<bool> Add(Session session)
    {
        await _unitOfWork.SessionRepository.Add(session);
        return true;
    }

    public Task Complete()
    {
        return _unitOfWork.Complete();
    }

    public void Dispose()
    {
        _unitOfWork?.Dispose();
        GC.SuppressFinalize(this);
    }

    public async Task<Session> GetByRefreshToken(string refreshToken, int expirationRefreshTokenMinutes)
    {
        return await _unitOfWork.SessionRepository.GetByRefreshToken(refreshToken, expirationRefreshTokenMinutes);
    }

    public async Task<bool> Update(Session session)
    {
        await _unitOfWork.SessionRepository.Update(session);
        return true;
    }
}
