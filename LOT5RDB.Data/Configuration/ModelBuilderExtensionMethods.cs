using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOT5RDB.Core.Equipment.DataObjects;
using LOT5RDB.Core.Skills.DataObjects;
using Microsoft.EntityFrameworkCore;

namespace LOT5RDB.Data.Configuration
{
    public static class ModelBuilderExtensionMethods 
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            var skillGroups = DataSeeds.GetSkillGroups();
            var skills = DataSeeds.GetSkills();

            modelBuilder.Entity<SkillGroup>(s => s.HasData(skillGroups));
            modelBuilder.Entity<Skill>(s => s.HasData(skills));
        }

        
    }
}
