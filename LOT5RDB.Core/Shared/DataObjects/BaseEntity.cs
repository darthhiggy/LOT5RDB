using System.ComponentModel;
using LOT5RDB.Core.Shared.Interfaces;

namespace LOT5RDB.Core.Shared.DataObjects;

public abstract class BaseEntity<T> : IEntity<T> where T : IComparable
{
    public T Id { get; set; }
    public string Name { get; set; }
    
    [DefaultValue(true)]
    public bool IsActive { get; set; }
}
