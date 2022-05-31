using LOT5RDB.Data.EquipmentDb;
using LOT5RDB.Equipment.Shared.ItemQualities.Interfaces;
using LOT5RDB.Equipment.Shared.ItemQualities.Models;

namespace LOT5RDB.Data.Repositories.EquipmentRepos;

public class ItemQualitiesRepository: BaseRepository<ItemQualityModel, int>, IItemQualitiesRepository
{

    public ItemQualitiesRepository(EquipmentDbContext dbContext) : base(dbContext)
    {
    }
}
