using LOT5RDB.Skills.Models;
using LOT5RDB.Core.Shared.DataObjects;
using Microsoft.EntityFrameworkCore;

namespace LOT5RDB.Data.Configuration.Skills;

public static class SkillExtensionMethods
{
    public static ModelBuilder SqlSkillSeedData(this ModelBuilder modelBuilder)
    {
        var dataSeeder = new DataSeeds();
        modelBuilder.Entity<SkillGroupModel>(s => s.HasData(dataSeeder.GetSkillGroups()));
        modelBuilder.Entity<SkillModel>(s => s.HasData(dataSeeder.GetSkills));
        return modelBuilder;
    }

    public static ModelBuilder NoSqlSkillSeedData(this ModelBuilder modelBuilder)
    {
        var dataSeeder = new DataSeeds();
        modelBuilder.Entity<LongText>(e => e.HasData(dataSeeder.SkillDescriptions));
        modelBuilder.Entity<LongText>(e => e.HasData(dataSeeder.SkillGroupDescriptions));
        return modelBuilder;
    }
}
