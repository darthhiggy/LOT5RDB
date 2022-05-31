using LOT5RDB.Core.Shared.DataObjects;

namespace LOT5RDB.Core.Shared.Interfaces;

public interface IDescriptionRepo 
{
    Task<LongText> GetLongTextByIdAsync(Guid id);
    Task<LongText> AddLongTextAsync(LongText longText);
    Task<LongText> UpdateLongTextAsync(LongText longText);
    Task<int> DeleteLongTextAsync(Guid id);
}
