using MediatR;

namespace LOT5RDB.Equipment.Shared.Weapons.Commands;

public class DeleteWeaponCommand : IRequest<int>
{
    public int Id { get; set; }
}
