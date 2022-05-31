using LOT5RDB.Equipment.Shared.ItemQualities.Command;
using LOT5RDB.Equipment.Shared.ItemQualities.Interfaces;
using MediatR;

namespace LOT5RDB.Equipment.Server.ItemQualities.CommandHandlers;

public class DeleteItemQualityCommandHandler : IRequestHandler<DeleteItemQualityCommand, int>
{
    private readonly IItemQualitiesRepository _itemQualitiesRepository;
    public DeleteItemQualityCommandHandler(IItemQualitiesRepository itemQualitiesRepository)
    {
        _itemQualitiesRepository = itemQualitiesRepository;
    }
    
    public async Task<int> Handle(DeleteItemQualityCommand request, CancellationToken cancellationToken)
    {
        return await _itemQualitiesRepository.Delete(request.Id);
    }
}
