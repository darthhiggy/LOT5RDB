using LOT5RDB.Equipment.Shared.ItemQualities.Models;
using MediatR;

namespace LOT5RDB.Equipment.Shared.ItemQualities.Command;

public class AddItemQualityCommand : IRequest<ItemQualityModel>
{
    public AddItemQualityCommand(ItemQualityModel newItemQuality)
    {
        NewItemQuality = newItemQuality;
    }
    public ItemQualityModel NewItemQuality { get; set; }
}
