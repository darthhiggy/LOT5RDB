using LOT5RDB.Equipment.Shared.ItemQualities.Models;
using MediatR;

namespace LOT5RDB.Equipment.Shared.ItemQualities.Command;

public class UpdateItemQualityCommand : IRequest<ItemQualityModel>
{
    public UpdateItemQualityCommand(ItemQualityModel updatedItemQuality)
    {
        UpdatedItemQuality = updatedItemQuality;
    }
    public ItemQualityModel UpdatedItemQuality { get; set; }
}
