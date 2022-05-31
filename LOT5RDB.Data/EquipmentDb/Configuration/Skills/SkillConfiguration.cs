using LOT5RDB.Skills.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace LOT5RDB.Data.EquipmentDb.Configuration.Skills;

public class SkillConfiguration : IEntityTypeConfiguration<SkillModel>
{
    private const string ResourceName = "LOT5RDB.Data.EquipmentDb.Configuration.Skills.DataSeeds.Skills.json";
    public void Configure(EntityTypeBuilder<SkillModel> builder)
    {
        builder.ToTable("Skills", "Skills");
        builder.HasKey(k => k.Id);
        builder.HasOne(s => s.SkillGroup)
            .WithMany(s => s.Skills);
        builder.Navigation(s => s.SkillGroup).AutoInclude();
        builder.HasData(JsonConvert.DeserializeObject<List<SkillModel>>(ConfigurationHelper.GetJsonStringFromEmbeddedResource(ResourceName)) ?? new List<SkillModel>());
    }
}
