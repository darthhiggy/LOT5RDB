using LOT5RDB.Core.Shared.DataObjects;
using LOT5RDB.Data.EquipmentDb.Configuration;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace LOT5RDB.Data.DescriptionsDb;

public class DescriptionsDbContext : DbContext
{
    private const string DescriptionsSeedData = "LOT5RDB.Data.DescriptionsDb.Configuration.DataSeeds.DescriptionSeeds.json";
    public DescriptionsDbContext(DbContextOptions<DescriptionsDbContext> contextOptions)
        : base(contextOptions)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }

    public DbSet<LongText> Descriptions { get; set; } = null!;
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LongText>().HasData(JsonConvert.DeserializeObject<List<LongText>>(
                                                ConfigurationHelper.GetJsonStringFromEmbeddedResource(DescriptionsSeedData)) 
                                                ?? new List<LongText>());
    }
}
