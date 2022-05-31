using LOT5RDB.Equipment.Shared.Weapons.Models;
using MediatR;

namespace LOT5RDB.Equipment.Shared.Weapons.Queries;

public class GetWeaponsQuery : IRequest<List<WeaponModel>>
{
    public GetWeaponsQuery(string? searchString = null)
    {
        SearchString = searchString;
    }
    public string? SearchString { get; set; }
}
