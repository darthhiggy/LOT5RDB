using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOT5RDB.Core.Equipment.DataObjects
{
    public interface IEquipmentRepository
    {
        List<Weapon> GetAllWeapons();
        List<Weapon> SearchWeaponByName(string searchString);
        Weapon GetWeaponById(int id);
        Weapon AddWeapon(Weapon weapon);
        Weapon UpdateWeapon(Weapon weapon);
        int DeleteWeapon(int id);
    }
}
