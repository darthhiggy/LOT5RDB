using LOT5RDB.Equipment.Models;
using LOT5RDB.Core.Shared.DataObjects;
using Microsoft.EntityFrameworkCore;

namespace LOT5RDB.Data.Configuration.Equipment;

public static class EquipmentExtensionMethods
{
    public static ModelBuilder SqlEquipmentSeedData(this ModelBuilder modelBuilder)
    {
        var dataSeeder = new DataSeeds();

        return modelBuilder.Entity<WeaponModel>(e => e.HasData(dataSeeder.GetWeapons()));
    }

    public static ModelBuilder NoSqlEquipmentSeedData(this ModelBuilder modelBuilder)
    {
        var dataSeeder = new DataSeeds();

        return modelBuilder.Entity<LongText>(e => e.HasData(dataSeeder.SkillDescriptions.Values));
    }

}
