using LOT5RDB.Equipment.Shared.ItemQualities.Models;
using MediatR;

namespace LOT5RDB.Equipment.Shared.ItemQualities.Queries;

public class GetItemQualitiesQuery : IRequest<List<ItemQualityModel>>
{
    public GetItemQualitiesQuery(string? searchString = null)
    {
        SearchString = searchString;
    }
    public string? SearchString { get; set; }
}
