using LOT5RD.Equipment.Interfaces;
using LOT5RD.Equipment.Models;
using LOT5RDB.Data.Configuration;

namespace LOT5RDB.Data.Repositories
{
    public class InMemoryEquipmentRepo : IEquipmentRepository
    {
        private readonly DataSeeds _seedData;

        public InMemoryEquipmentRepo()
        {
            _seedData = new DataSeeds();
        }

        public int SaveChanges() => 0;
        public List<WeaponModel> GetAllWeapons() => _seedData.GetWeapons();
        public List<WeaponModel> SearchWeaponByName(string searchString)
            => _seedData.GetWeapons().Where(w => w.Name.ToLower().StartsWith(searchString.ToLower())).ToList();
        public WeaponModel GetWeaponById(int id) 
            => _seedData.GetWeapons().First(w => w.Id == id) 
               ?? new WeaponModel();
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
}
