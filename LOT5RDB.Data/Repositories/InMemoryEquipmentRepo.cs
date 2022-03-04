using LOT5RD.Equipment.Interfaces;
using LOT5RD.Equipment.Models;
using LOT5RDB.Data.Configuration;

namespace LOT5RDB.Data.Repositories
{
    public class InMemoryEquipmentRepo : IEquipmentRepository
    {
        public List<WeaponModel> Weapons { get; set; } = new List<WeaponModel>();

        public InMemoryEquipmentRepo()
        {
            var seedData = new DataSeeds();
            Weapons = seedData.
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }
        public List<WeaponModel> GetAllWeapons()
        {
            throw new NotImplementedException();
        }
        public List<WeaponModel> SearchWeaponByName(string searchString)
        {
            throw new NotImplementedException();
        }
        public WeaponModel GetWeaponById(int id)
        {
            throw new NotImplementedException();
        }
        public WeaponModel AddWeapon(WeaponModel weapon)
        {
            throw new NotImplementedException();
        }
        public WeaponModel UpdateWeapon(WeaponModel weapon)
        {
            throw new NotImplementedException();
        }
        public int DeleteWeapon(int id)
        {
            throw new NotImplementedException();
        }
    }
}
