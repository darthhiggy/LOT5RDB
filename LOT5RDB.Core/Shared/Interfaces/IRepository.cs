namespace LOT5RDB.Core.Shared.Interfaces;

public interface IRepository<TEntity, in TComparable> where TEntity : IEntity<TComparable> where TComparable : IComparable
{
    Task<List<TEntity>> GetAllAsync();
    Task<List<TEntity>> SearchByName(string searchString);
    Task<TEntity> GetById(TComparable id);
    Task<TEntity> Add(TEntity entity);
    Task<TEntity> Update(TEntity entity);
    Task<int> Delete(TComparable id);
}
