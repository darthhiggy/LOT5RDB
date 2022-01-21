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
    public class GripConfiguration : IEntityTypeConfiguration<Grip>
    {
        public void Configure(EntityTypeBuilder<Grip> builder)
        {
            builder.ToTable("Grips", schema: "Equipment");

            builder.Property(e => e.GripType).HasConversion<string>();

        }
    }
}
