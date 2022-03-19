using LOT5RDB.Core.Shared.DataObjects;

namespace LOT5RDB.Core.Shared.Interfaces;

public interface ILongTextRepo
{
    LongText GetLongTextById(Guid id);
    LongText AddLongText(LongText longText);
    LongText UpdateLongText(LongText longText);
    int DeleteLongText(Guid id);
}
