using System;
using Ofernandoavila.FoodDelivery.Business.Models.Enumerator;

namespace Ofernandoavila.FoodDelivery.Business.Models.Utils.Dictionary;

public static class CheckDictionary
{
    public static bool ValidateRole(Guid role)
    {
        return EnumDictionary.RoleDictionary().ContainsValue(role);
    }

    public static int GetRoleEnum(Guid guid)
    {
        return EnumDictionary.RoleDictionary().FirstOrDefault( r => r.Value == guid).Key;
    }

    public static Guid GetRoleId(RoleEnum role)
    {
        return EnumDictionary.RoleDictionary().FirstOrDefault( r => r.Key == (int)role).Value;
    }
}
