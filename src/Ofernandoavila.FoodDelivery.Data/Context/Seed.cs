using Microsoft.EntityFrameworkCore;
using Ofernandoavila.FoodDelivery.Business.Models.AccessControl;
using Ofernandoavila.FoodDelivery.Business.Models.Parameter;

namespace Ofernandoavila.FoodDelivery.Data.Context;

public static class Seed
{
    public static void SeedEntities(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasData(
            new Role(Guid.Parse("0b9b96b8-c083-4c5e-b2b3-c9b142302def"), "System"),
            new Role(Guid.Parse("775611a5-7f0b-46b9-8a2c-1f2526d865e5"), "Administrator"),
            new Role(Guid.Parse("4b4f973b-2f57-4671-a302-60cfecbc1bf9"), "StoreOwner"),
            new Role(Guid.Parse("63569f70-acee-4296-83a7-ef495203c890"), "Client")
        );

        modelBuilder.Entity<User>().HasData(
            new User(Guid.Parse("e4493800-676b-4d9a-921a-f0bf171462f1"),
                        "System",
                        "fernandoavilajunior@gmail.com",
                        "12e8f78ad914d3aef2532615a71c541bbed8473a6140399ca54d3ddd516e1ad8", //@Aa12345 
                        Guid.Parse("0b9b96b8-c083-4c5e-b2b3-c9b142302def"))
        );
    }
}