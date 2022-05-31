using LOT5RDB.Equipment.Shared.Weapons.Models;
using MediatR;

namespace LOT5RDB.Equipment.Shared.Weapons.Commands;

public class CreateNewWeaponCommand : IRequest<WeaponModel>
{
    public CreateNewWeaponCommand(WeaponModel newWeapon)
    {
        NewWeapon = newWeapon;
    }
    public WeaponModel NewWeapon { get; set; }
}
