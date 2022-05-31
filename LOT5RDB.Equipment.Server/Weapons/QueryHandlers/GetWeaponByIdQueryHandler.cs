using LOT5RDB.Equipment.Shared.Weapons.Interfaces;
using LOT5RDB.Equipment.Shared.Weapons.Models;
using LOT5RDB.Equipment.Shared.Weapons.Queries;
using MediatR;

namespace LOT5RDB.Equipment.Server.Weapons.QueryHandlers;

public class GetWeaponByIdQueryHandler : IRequestHandler<GetWeaponByIdQuery, WeaponModel>
{
    private readonly IWeaponsRepository _weaponsRepository;
    public GetWeaponByIdQueryHandler(IWeaponsRepository weaponsRepository)
    {
        _weaponsRepository = weaponsRepository;

    }

    public async Task<WeaponModel> Handle(GetWeaponByIdQuery request, CancellationToken cancellationToken)
    {
        return await _weaponsRepository.GetById(request.Id);
    }
}
