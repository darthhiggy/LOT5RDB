using LOT5RDB.Skills.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace LOT5RDB.Data.EquipmentDb.Configuration.Skills;

public class SkillGroupConfiguration : IEntityTypeConfiguration<SkillGroupModel>
{
    private const string ResourceName = "LOT5RDB.Data.EquipmentDb.Configuration.Skills.DataSeeds.SkillGroups.json";
    public void Configure(EntityTypeBuilder<SkillGroupModel> builder)
    {
        builder.ToTable("SkillGroups", "Skills")
            .HasKey(k => k.Id);

        builder.HasData(JsonConvert.DeserializeObject<List<SkillGroupModel>>(ConfigurationHelper.GetJsonStringFromEmbeddedResource(ResourceName)) ?? new List<SkillGroupModel>());
    }
}
