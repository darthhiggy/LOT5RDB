using LOT5RDB.Equipment.Shared.ItemQualities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace LOT5RDB.Data.EquipmentDb.Configuration.Equipment;

public class ItemQualityConfiguration : IEntityTypeConfiguration<ItemQualityModel>
{
    private const string ResourceName = "LOT5RDB.Data.EquipmentDb.Configuration.Equipment.DataSeeds.ItemQualities.json";
    public void Configure(EntityTypeBuilder<ItemQualityModel> builder)
    {
        builder.ToTable("ItemQualities", "Equipment");

        builder.Navigation(s => s.Weapons).AutoInclude();
        
        builder.HasData(JsonConvert.DeserializeObject<List<ItemQualityModel>>(ConfigurationHelper.GetJsonStringFromEmbeddedResource(ResourceName)) ?? new List<ItemQualityModel>());
    }
}
