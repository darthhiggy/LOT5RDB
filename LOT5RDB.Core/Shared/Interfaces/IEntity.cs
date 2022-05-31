namespace LOT5RDB.Core.Shared.Interfaces;

public interface IEntity<T> where T : IComparable
{
    T Id { get; set; }
    string Name { get; set; }
    bool IsActive { get; set; }
}
