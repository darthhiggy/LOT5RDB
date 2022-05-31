using LOT5RDB.Equipment.Shared.ItemQualities.Command;
using LOT5RDB.Equipment.Shared.ItemQualities.Interfaces;
using LOT5RDB.Equipment.Shared.ItemQualities.Models;
using MediatR;

namespace LOT5RDB.Equipment.Server.ItemQualities.CommandHandlers;

public class UpdateItemQualityCommandHandler : IRequestHandler<UpdateItemQualityCommand, ItemQualityModel>
{
    private readonly IItemQualitiesRepository _itemQualitiesRepository;
    public UpdateItemQualityCommandHandler(IItemQualitiesRepository itemQualitiesRepository)
    {
        _itemQualitiesRepository = itemQualitiesRepository;
    }

    public async Task<ItemQualityModel> Handle(UpdateItemQualityCommand request, CancellationToken cancellationToken)
    {
        return await _itemQualitiesRepository.Update(request.UpdatedItemQuality);
    }
}
