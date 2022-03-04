using LOT5RD.Skills.Models;
using Microsoft.EntityFrameworkCore;

namespace LOT5RDB.Data.Configuration
{
    public static class ModelBuilderExtensionMethods 
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            var skillGroups = DataSeeds.GetSkillGroups();
            var skills = DataSeeds.GetSkills();

            modelBuilder.Entity<SkillGroupModel>(s => s.HasData(skillGroups));
            modelBuilder.Entity<SkillModel>(s => s.HasData(skills));
        }

        
    }
}
