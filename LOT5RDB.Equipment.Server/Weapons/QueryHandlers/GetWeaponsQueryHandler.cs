using LOT5RDB.Equipment.Shared.Weapons.Interfaces;
using LOT5RDB.Equipment.Shared.Weapons.Models;
using LOT5RDB.Equipment.Shared.Weapons.Queries;
using MediatR;

namespace LOT5RDB.Equipment.Server.Weapons.QueryHandlers;

public class GetWeaponsQueryHandler : IRequestHandler<GetWeaponsQuery, List<WeaponModel>>
{
    private readonly IWeaponsRepository _weaponsRepository;
    
    public GetWeaponsQueryHandler(IWeaponsRepository weaponsRepository)
    {
        _weaponsRepository = weaponsRepository;

    }

    public async Task<List<WeaponModel>> Handle(GetWeaponsQuery request, CancellationToken cancellationToken)
    {
        return string.IsNullOrWhiteSpace(request.SearchString)
            ? await _weaponsRepository.GetAllAsync()
            : await _weaponsRepository.SearchByName(request.SearchString);
    }
}
