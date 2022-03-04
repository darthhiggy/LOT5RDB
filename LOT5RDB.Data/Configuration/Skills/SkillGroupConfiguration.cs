using LOT5RD.Skills.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LOT5RDB.Data.Configuration.Skills
{
    public class SkillGroupConfiguration : IEntityTypeConfiguration<SkillGroupModel>
    {
        public void Configure(EntityTypeBuilder<SkillGroupModel> builder)
        {
            builder.ToTable("SkillGroups", schema: "Skills");
        }
    }
}
