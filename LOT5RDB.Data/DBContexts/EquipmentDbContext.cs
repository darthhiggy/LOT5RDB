using LOT5RD.Equipment.Models;
using LOT5RD.Skills.Models;
using LOT5RDB.Data.Configuration.Equipment;
using LOT5RDB.Data.Configuration.Skills;
using Microsoft.EntityFrameworkCore;

namespace LOT5RDB.Data.DBContexts
{
    public class EquipmentDbContext : DbContext
    {
        public DbSet<WeaponModel> Weapons { get; set; }
        public DbSet<ItemQualityModel> ItemQualities { get; set; }
        public DbSet<Grip> Grips { get; set; }
        public DbSet<SkillModel> Skills { get; set; }
        public DbSet<SkillGroupModel> SkillGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                    "Server = (localdb)\\mssqllocaldb; Database = LOT5RDB; Trusted_Connection = True; ")
                .EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SkillGroupConfiguration());
            modelBuilder.ApplyConfiguration(new SkillConfiguration());
            modelBuilder.ApplyConfiguration(new GripConfiguration());
            modelBuilder.ApplyConfiguration(new ItemQualityConfiguration());
            modelBuilder.ApplyConfiguration(new WeaponConfiguration());
        }
    }
}
