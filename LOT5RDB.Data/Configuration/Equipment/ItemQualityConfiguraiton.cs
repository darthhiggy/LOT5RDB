using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOT5RDB.Core.Equipment.DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LOT5RDB.Data.Configuration.Equipment
{
    public class ItemQualityConfiguraiton : IEntityTypeConfiguration<ItemQuality>
    {
        public void Configure(EntityTypeBuilder<ItemQuality> builder)
        {
            builder.ToTable("ItemQualities", schema: "Equipment");
        }
    }
}
