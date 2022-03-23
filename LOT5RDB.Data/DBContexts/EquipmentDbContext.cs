using LOT5RDB.Equipment.Models;
using LOT5RDB.Skills.Models;
using LOT5RDB.Data.Configuration;
using LOT5RDB.Data.Configuration.Equipment;
using LOT5RDB.Data.Configuration.Skills;
using Microsoft.EntityFrameworkCore;

namespace LOT5RDB.Data.DBContexts;

public class EquipmentDbContext : DbContext
{
    public EquipmentDbContext(DbContextOptions<EquipmentDbContext> contextOptions)
        : base(contextOptions)
    {

    }
    public DbSet<WeaponModel> Weapons { get; set; } = null!;
    public DbSet<ItemQualityModel> ItemQualities { get; set; } = null!;
    public DbSet<SkillModel> Skills { get; set; } = null!;
    public DbSet<SkillGroupModel> SkillGroups { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .EnableSensitiveDataLogging(true);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SkillGroupConfiguration());
        modelBuilder.ApplyConfiguration(new SkillConfiguration());
        modelBuilder.ApplyConfiguration(new ItemQualityConfiguration());
        modelBuilder.ApplyConfiguration(new WeaponConfiguration());

        // seeding data needs to happen at the end of all other configuration
        modelBuilder.GetSqlDataSeeds();
    }
}
