using LOT5RD.Equipment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LOT5RDB.Data.Configuration.Equipment
{
    public class ItemQualityConfiguration : IEntityTypeConfiguration<ItemQualityModel>
    {
        public void Configure(EntityTypeBuilder<ItemQualityModel> builder)
        {
            builder.ToTable("ItemQualities", schema: "Equipment");
        }
    }
}
