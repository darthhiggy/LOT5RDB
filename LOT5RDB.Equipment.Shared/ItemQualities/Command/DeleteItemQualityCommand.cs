using MediatR;

namespace LOT5RDB.Equipment.Shared.ItemQualities.Command;

public class DeleteItemQualityCommand : IRequest<int>
{
    public int Id { get; set; }
}
