using LOT5RD.Equipment.Models;
using LOT5RDB.Core.Shared.DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;


namespace LOT5RDB.Data.Configuration.Equipment
{
    public class WeaponConfiguration : IEntityTypeConfiguration<WeaponModel>

    {
        public void Configure(EntityTypeBuilder<WeaponModel> builder)
        {
            builder.ToTable("Weapons", schema: "Equipment");

            // builder
            //     .HasMany(w => w.Grips)
            //     .WithMany(w => w.Weapons)
            //     .UsingEntity(j => j.ToTable("WeaponGrips"));

            builder.Property(e => e.Grips).HasConversion(v
                => JsonConvert.SerializeObject(v),
            v
                => JsonConvert.DeserializeObject<List<Grip>>(v) ?? new List<Grip>());

            builder
                .HasMany(w => w.Qualities)
                .WithMany(w => w.Weapons)
                .UsingEntity(j => j.ToTable("WeaponItemQualities"));

            builder.Property(e => e.Price).HasConversion(v 
                => v.Amount, v 
                => new Price(v));

            builder.Property(e => e.Range).HasConversion(v 
                => $"{v.MinRange}-{v.MaxRange}", v 
                => new Ranges(v));
        }
    }
}
