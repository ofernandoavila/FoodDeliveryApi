using AutoMapper;
using Ofernandoavila.FoodDelivery.Api.ViewModels.AccessControl;
using Ofernandoavila.FoodDelivery.Api.ViewModels.Parameter;
using Ofernandoavila.FoodDelivery.Business.Models.AccessControl;
using Ofernandoavila.FoodDelivery.Business.Models.Parameter;
using System.Diagnostics.CodeAnalysis;

namespace Ofernandoavila.FoodDelivery.Api.Configurations;

[ExcludeFromCodeCoverage]
public class AutomapperConfig : Profile
{
    public AutomapperConfig()
    {
        CreateMap<Session, SessionViewModel>().ReverseMap();
        CreateMap<User, UserCreateViewModel>().ReverseMap();
        CreateMap<User, UserLoginViewModel>().ReverseMap();
        CreateMap<User, UserViewModel>().ReverseMap();

        CreateMap<Role, RoleViewModel>().ReverseMap();
    }
}
