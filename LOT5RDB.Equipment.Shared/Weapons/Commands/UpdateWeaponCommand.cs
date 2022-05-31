using LOT5RDB.Core.Shared.Interfaces;
using LOT5RDB.Equipment.Shared.Weapons.Models;
using MediatR;

namespace LOT5RDB.Equipment.Shared.Weapons.Commands;

public class UpdateWeaponCommand : IRequest<WeaponModel>
{
    public UpdateWeaponCommand(WeaponModel updatedWeaponModel)
    {
        UpdatedWeaponModel = updatedWeaponModel;
    }
    public WeaponModel UpdatedWeaponModel { get; set; }
}
