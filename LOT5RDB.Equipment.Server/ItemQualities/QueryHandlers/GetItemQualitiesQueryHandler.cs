using LOT5RDB.Equipment.Shared.ItemQualities.Interfaces;
using LOT5RDB.Equipment.Shared.ItemQualities.Models;
using LOT5RDB.Equipment.Shared.ItemQualities.Queries;
using MediatR;

namespace LOT5RDB.Equipment.Server.ItemQualities.QueryHandlers;

public class GetItemQualitiesQueryHandler : IRequestHandler<GetItemQualitiesQuery, List<ItemQualityModel>>
{
    private readonly IItemQualitiesRepository _itemQualitiesRepository;
    public GetItemQualitiesQueryHandler(IItemQualitiesRepository itemQualitiesRepository)
    {
        _itemQualitiesRepository = itemQualitiesRepository;

    }

    public async Task<List<ItemQualityModel>> Handle(GetItemQualitiesQuery request, CancellationToken cancellationToken)
    {
        return string.IsNullOrWhiteSpace(request.SearchString)
            ? await _itemQualitiesRepository.GetAllAsync()
            : await _itemQualitiesRepository.SearchByName(request.SearchString);
    }
}
