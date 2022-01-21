using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOT5RDB.Core.Equipment.DataObjects;
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

        public List<Weapon> GetAllWeapons()
        {
            return EquipmentDbContext.Weapons.ToList();
        }

        public List<Weapon> SearchWeaponByName(string searchString)
        {
            return EquipmentDbContext.Weapons.Where(w => w.Name.ToLower().StartsWith(searchString.ToLower())).ToList();
        }

        public Weapon GetWeaponById(int id)
        {
            return EquipmentDbContext.Weapons.Find(id) ?? new Weapon();
        }

        public Weapon AddWeapon(Weapon weapon)
        {
            EquipmentDbContext.Weapons.Add(weapon);
            return weapon;
        }

        public Weapon UpdateWeapon(Weapon weapon)
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

        public int Commit()
        {
            return EquipmentDbContext.SaveChanges();
        }
    }
}
