using LOT5RDB.Equipment.Shared.ItemQualities.Interfaces;
using LOT5RDB.Equipment.Shared.ItemQualities.Models;
using LOT5RDB.Equipment.Shared.ItemQualities.Queries;
using MediatR;

namespace LOT5RDB.Equipment.Server.ItemQualities.QueryHandlers;

public class GetItemQualityByIdQueryHandler : IRequestHandler<GetItemQualityByIdQuery, ItemQualityModel>
{
    private readonly IItemQualitiesRepository _itemQualitiesRepository;
    public GetItemQualityByIdQueryHandler(IItemQualitiesRepository itemQualitiesRepository)
    {
        _itemQualitiesRepository = itemQualitiesRepository;
    }

    public async Task<ItemQualityModel> Handle(GetItemQualityByIdQuery request, CancellationToken cancellationToken)
    {
        return await _itemQualitiesRepository.GetById(request.Id);
    }
}
