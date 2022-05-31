using LOT5RDB.Equipment.Shared.Weapons.Commands;
using LOT5RDB.Equipment.Shared.Weapons.Interfaces;
using LOT5RDB.Equipment.Shared.Weapons.Models;
using MediatR;

namespace LOT5RDB.Equipment.Server.Weapons.CommandHandlers;

public class UpdateWeaponCommandHandler : IRequestHandler<UpdateWeaponCommand, WeaponModel>
{
    private readonly IWeaponsRepository _weaponsRepository;
    public UpdateWeaponCommandHandler(IWeaponsRepository weaponsRepository)
    {
        _weaponsRepository = weaponsRepository;
    }

    public async Task<WeaponModel> Handle(UpdateWeaponCommand request, CancellationToken cancellationToken)
    {
        return await _weaponsRepository.Update(request.UpdatedWeaponModel);
    }
}
