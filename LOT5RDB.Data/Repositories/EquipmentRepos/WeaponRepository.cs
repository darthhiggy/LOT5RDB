using LOT5RDB.Data.EquipmentDb;
using LOT5RDB.Equipment.Shared.Weapons.Interfaces;
using LOT5RDB.Equipment.Shared.Weapons.Models;

namespace LOT5RDB.Data.Repositories.EquipmentRepos;

public class WeaponRepository : BaseRepository<WeaponModel, int> , IWeaponsRepository
{
    public WeaponRepository(EquipmentDbContext equipmentDbContext) : base(equipmentDbContext)
    {
        
    }
}
