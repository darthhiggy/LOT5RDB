using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOT5RDB.Core.Equipment.DataObjects;
using LOT5RDB.Core.Shared.DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LOT5RDB.Data.Configuration.Equipment
{
    public class WeaponConfiguration : IEntityTypeConfiguration<Weapon>

    {
        public void Configure(EntityTypeBuilder<Weapon> builder)
        {
            builder.ToTable("Weapons", schema: "Equipment");

            builder
                .HasMany(w => w.Grips)
                .WithMany(w => w.Weapons)
                .UsingEntity(j => j.ToTable("WeaponGrips"));

            builder
                .HasMany(w => w.Qualities)
                .WithMany(w => w.Weapons)
                .UsingEntity(j => j.ToTable("WeaponItemQualities"));

            builder.Property(e => e.Price).HasConversion(v => v.Amount, v => new Price(v));

            builder.Property(e => e.Range).HasConversion(v => $"{v.MinRange}-{v.MaxRange}", v => new Ranges(v));
        }
    }
}
