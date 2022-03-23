using LOT5RDB.Equipment.Interfaces;
using LOT5RDB.Equipment.Models;
using LOT5RDB.Data.Configuration;

namespace LOT5RDB.Data.Repositories;

public class InMemoryEquipmentRepo : IEquipmentRepository
{
    private readonly DataSeeds _seedData;

    public InMemoryEquipmentRepo()
    {
        _seedData = new DataSeeds();
    }

    public int SaveChanges()
    {
        return 0;
    }
    public List<WeaponModel> GetAllWeapons()
    {
        return _seedData.GetWeapons();
    }
    public List<WeaponModel> SearchWeaponByName(string searchString)
    {
        return _seedData.GetWeapons().Where(w => w.Name.ToLower().StartsWith(searchString.ToLower())).ToList();
    }
    public WeaponModel GetWeaponById(int id)
    {
        return _seedData.GetWeapons().First(w => w.Id == id)
               ?? new WeaponModel();
    }
    public WeaponModel AddWeapon(WeaponModel weapon)
    {
        return weapon;
    }
    public WeaponModel UpdateWeapon(WeaponModel weapon)
    {
        return weapon;
    }
    public int DeleteWeapon(int id)
    {
        return 0;
    }
}
