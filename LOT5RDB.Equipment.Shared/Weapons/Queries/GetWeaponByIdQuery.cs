using LOT5RDB.Equipment.Shared.Weapons.Models;
using MediatR;

namespace LOT5RDB.Equipment.Shared.Weapons.Queries;

public class GetWeaponByIdQuery : IRequest<WeaponModel>
{
    public int Id { get; set; }
}
