using LOT5RDB.Core.Shared.DataObjects;
using LOT5RDB.Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace LOT5RDB.Data.DBContexts;

public class DescriptionsDbContext : DbContext
{
    public DescriptionsDbContext(DbContextOptions<DescriptionsDbContext> contextOptions)
        : base(contextOptions)
    {

    }

    public DbSet<LongText> Descriptions { get; set; } = null!;
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.GetNoSqlDataSeeds();
    }
}
