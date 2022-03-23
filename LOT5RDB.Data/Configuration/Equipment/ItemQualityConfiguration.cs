using LOT5RDB.Equipment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LOT5RDB.Data.Configuration.Equipment;

public class ItemQualityConfiguration : IEntityTypeConfiguration<ItemQualityModel>
{
    public void Configure(EntityTypeBuilder<ItemQualityModel> builder)
    {
        builder.ToTable("ItemQualities", "Equipment");
    }
}
