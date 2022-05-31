using LOT5RDB.Core.Shared.DataObjects;
using LOT5RDB.Equipment.Shared.Weapons.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace LOT5RDB.Data.EquipmentDb.Configuration.Equipment;

public class WeaponConfiguration : IEntityTypeConfiguration<WeaponModel>

{
    private const string WeaponSeedData = "LOT5RDB.Data.EquipmentDb.Configuration.Equipment.DataSeeds.Weapons.json";
    private const string WeaponItemQualitySeedData = "LOT5RDB.Data.EquipmentDb.Configuration.Equipment.DataSeeds.WeaponItemQualities.json";
    public void Configure(EntityTypeBuilder<WeaponModel> builder)
    {
        builder.ToTable("Weapons", "Equipment");

        builder.Property(e => e.Grips).HasConversion(v
            => JsonConvert.SerializeObject(v),
        v
            => JsonConvert.DeserializeObject<List<Grip>>(v) ?? new List<Grip>());
        builder.Property(e => e.Price).HasConversion(v
            => v.Amount,
        v
            => new Price(v));
        builder.Property(e => e.Range).HasConversion(v
            => $"{v.MinRange}-{v.MaxRange}",
        v
            => new Ranges(v));
        builder.HasData(JsonConvert.DeserializeObject<List<WeaponModel>>(
        ConfigurationHelper.GetJsonStringFromEmbeddedResource(WeaponSeedData)) 
                        ?? new List<WeaponModel>());

        builder.Navigation(w => w.Qualities).AutoInclude();

        builder.Navigation(w => w.Skill).AutoInclude();
        
        var weaponItemQualityData = 
            JsonConvert.DeserializeAnonymousType(
            ConfigurationHelper.GetJsonStringFromEmbeddedResource(WeaponItemQualitySeedData)
            , new[] { new { QualitiesId = 1, WeaponsId = 1 } }) 
            ?? new[] { new { QualitiesId = 0, WeaponsId = 0 } };
        builder
            .HasMany(w => w.Qualities)
            .WithMany(w => w.Weapons)
            .UsingEntity(j => j.ToTable("WeaponItemQualities")
                .HasData(weaponItemQualityData));
    }

}
