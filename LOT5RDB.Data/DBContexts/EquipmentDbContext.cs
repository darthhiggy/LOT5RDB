using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOT5RDB.Core.Equipment.DataObjects;
using LOT5RDB.Core.Shared.DataObjects;
using LOT5RDB.Core.Skills.DataObjects;
using LOT5RDB.Data.Configuration;
using LOT5RDB.Data.Configuration.Equipment;
using LOT5RDB.Data.Configuration.Skills;
using Microsoft.EntityFrameworkCore;

namespace LOT5RDB.Data.DBContexts
{
    public class EquipmentDbContext : DbContext
    {
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<ItemQuality> ItemQualities { get; set; }
        public DbSet<Grip> Grips { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillGroup> SkillGroups { get; set; }

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
            modelBuilder.ApplyConfiguration(new ItemQualityConfiguraiton());
            modelBuilder.ApplyConfiguration(new WeaponConfiguration());
        }
    }
}
