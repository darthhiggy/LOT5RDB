using LOT5RDB.Data.Configuration.Equipment;
using LOT5RDB.Data.Configuration.Skills;
using Microsoft.EntityFrameworkCore;

namespace LOT5RDB.Data.Configuration;

public static class ModelBuilderExtensionMethods
{
    public static ModelBuilder GetSqlDataSeeds(this ModelBuilder modelBuilder)
    {
        return modelBuilder.SqlSkillSeedData()
            .SqlEquipmentSeedData();
    }
    public static ModelBuilder GetNoSqlDataSeeds(this ModelBuilder modelBuilder)
    {
        return modelBuilder.NoSqlSkillSeedData()
            .NoSqlEquipmentSeedData();
    }
}
