using LOT5RDB.Equipment.Shared.Weapons.Commands;
using LOT5RDB.Equipment.Shared.Weapons.Interfaces;
using MediatR;

namespace LOT5RDB.Equipment.Server.Weapons.CommandHandlers;

public class DeleteWeaponCommandHandler : IRequestHandler<DeleteWeaponCommand, int>
{
    private readonly IWeaponsRepository _weaponsRepository;
    public DeleteWeaponCommandHandler(IWeaponsRepository weaponsRepository)
    {
        _weaponsRepository = weaponsRepository;

    }

    public async Task<int> Handle(DeleteWeaponCommand request, CancellationToken cancellationToken)
    {
        return await _weaponsRepository.Delete(request.Id);
    }
}
