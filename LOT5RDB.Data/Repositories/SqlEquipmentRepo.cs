using LOT5RD.Equipment.Interfaces;
using LOT5RD.Equipment.Models;
using LOT5RDB.Data.DBContexts;
using Microsoft.EntityFrameworkCore;

namespace LOT5RDB.Data.Repositories
{
    public class SqlEquipmentRepo : IEquipmentRepository
    {
        public SqlEquipmentRepo(EquipmentDbContext equipmentDbContext)
        {
            EquipmentDbContext = equipmentDbContext;
        }

        public EquipmentDbContext EquipmentDbContext { get; }

        public List<WeaponModel> GetAllWeapons()
        {
            return EquipmentDbContext.Weapons.ToList();
        }

        public List<WeaponModel> SearchWeaponByName(string searchString)
        {
            return EquipmentDbContext.Weapons.Where(w => w.Name.ToLower().StartsWith(searchString.ToLower())).ToList();
        }

        public WeaponModel GetWeaponById(int id)
        {
            return EquipmentDbContext.Weapons.Find(id) ?? new WeaponModel();
        }

        public WeaponModel AddWeapon(WeaponModel weapon)
        {
            EquipmentDbContext.Weapons.Add(weapon);
            return weapon;
        }

        public WeaponModel UpdateWeapon(WeaponModel weapon)
        {
            var entity = EquipmentDbContext.Weapons.Attach(weapon);
            entity.State = EntityState.Modified;
            return weapon;
        }

        public int DeleteWeapon(int id)
        {
            var weapon = GetWeaponById(id);
            if (weapon.Id != 0)
            {
                EquipmentDbContext.Weapons.Remove(weapon);
            }

            return 0;
        }

        public int SaveChanges()
        {
            return EquipmentDbContext.SaveChanges();
        }
    }
}
