using LOT5RD.Equipment.Models;
using LOT5RDB.Core.Shared.Interfaces;

namespace LOT5RD.Equipment.Interfaces;

public interface IEquipmentRepository : IRepository
{
    List<WeaponModel> GetAllWeapons();
    List<WeaponModel> SearchWeaponByName(string searchString);
    WeaponModel GetWeaponById(int id);
    WeaponModel AddWeapon(WeaponModel weapon);
    WeaponModel UpdateWeapon(WeaponModel weapon);
    int DeleteWeapon(int id);

}