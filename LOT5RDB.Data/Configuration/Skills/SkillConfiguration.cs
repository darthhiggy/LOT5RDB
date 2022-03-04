using LOT5RD.Skills.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LOT5RDB.Data.Configuration.Skills
{
    public class SkillConfiguration : IEntityTypeConfiguration<SkillModel>
    {
        public void Configure(EntityTypeBuilder<SkillModel> builder)
        {
            builder.ToTable("Skills", schema: "Skills");
            builder.HasOne(s => s.SkillGroup)
                .WithMany(s => s.Skills);
        }
    }
}
