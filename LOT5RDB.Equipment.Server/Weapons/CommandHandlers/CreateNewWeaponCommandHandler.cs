using LOT5RDB.Equipment.Shared.Weapons.Commands;
using LOT5RDB.Equipment.Shared.Weapons.Interfaces;
using LOT5RDB.Equipment.Shared.Weapons.Models;
using MediatR;

namespace LOT5RDB.Equipment.Server.Weapons.CommandHandlers;

public class CreateNewWeaponCommandHandler : IRequestHandler<CreateNewWeaponCommand, WeaponModel>
{
    private readonly IWeaponsRepository _weaponsRepository;
    public CreateNewWeaponCommandHandler(IWeaponsRepository weaponsRepository)
    {
        _weaponsRepository = weaponsRepository;
    }

    public async Task<WeaponModel> Handle(CreateNewWeaponCommand request, CancellationToken cancellationToken)
    {
        return await _weaponsRepository.Add(request.NewWeapon);
    }
}
