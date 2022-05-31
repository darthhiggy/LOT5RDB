using LOT5RDB.Equipment.Shared.ItemQualities.Models;
using MediatR;

namespace LOT5RDB.Equipment.Shared.ItemQualities.Queries;

public class GetItemQualityByIdQuery : IRequest<ItemQualityModel>
{
    public int Id { get; set; }
}
