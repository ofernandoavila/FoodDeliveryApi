using System;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ofernandoavila.FoodDelivery.Api.ViewModels.DTO;
using Ofernandoavila.FoodDelivery.Business.Interfaces.Notification;
using Ofernandoavila.FoodDelivery.Business.Interfaces.User;

namespace Ofernandoavila.FoodDelivery.Api.Controllers.V1;

[Obsolete("Use v2.")]
[ApiVersion("1.0")]
[Authorize(Roles = "System")]
[Route("api/v{version:apiversion}")]
public class AppController(INotificator notificator,
                            IUser appUser) : MainController(notificator, appUser)
{
    [HttpGet("info")]
    [AllowAnonymous]
    public IActionResult GetInfo()
    {
        return CustomResponse(new AppInfo());
    }

    [HttpGet("status")]
    [AllowAnonymous]
    public IActionResult Get()
    {
        return CustomResponse("API V1 is working but is deprecated, use V2!");
    }

    [HttpPost("status")]
    [AllowAnonymous]
    public IActionResult Post()
    {
        return CustomResponse("API V1 is working but is deprecated, use V2!");
    }
}
