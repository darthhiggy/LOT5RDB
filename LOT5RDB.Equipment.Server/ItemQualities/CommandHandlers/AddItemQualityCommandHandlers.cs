using LOT5RDB.Equipment.Shared.ItemQualities.Command;
using LOT5RDB.Equipment.Shared.ItemQualities.Interfaces;
using LOT5RDB.Equipment.Shared.ItemQualities.Models;
using MediatR;

namespace LOT5RDB.Equipment.Server.ItemQualities.CommandHandlers;

public class AddItemQualityCommandHandlers : IRequestHandler<AddItemQualityCommand, ItemQualityModel>
{
    private readonly IItemQualitiesRepository _itemQualitiesRepository;
    public AddItemQualityCommandHandlers(IItemQualitiesRepository itemQualitiesRepository)
    {
        _itemQualitiesRepository = itemQualitiesRepository;

    }

    public async Task<ItemQualityModel> Handle(AddItemQualityCommand request, CancellationToken cancellationToken)
    {
        return await _itemQualitiesRepository.Add(request.NewItemQuality);
    }
}
