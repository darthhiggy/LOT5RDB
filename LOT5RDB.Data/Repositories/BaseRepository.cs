using LOT5RDB.Core.Shared.Interfaces;
using LOT5RDB.Data.EquipmentDb;
using Microsoft.EntityFrameworkCore;

namespace LOT5RDB.Data.Repositories;

public class BaseRepository<TEntity, TComparable> 
    : IRepository<TEntity, TComparable> 
    where TEntity : class, IEntity<TComparable>, new()
    where TComparable : IComparable
{
    protected readonly EquipmentDbContext DbContext;
    public BaseRepository(EquipmentDbContext dbContext)
    {
        DbContext = dbContext;

    }

    public async Task<List<TEntity>> GetAllAsync() => await DbContext.Set<TEntity>()
        .ToListAsync();
    
    public async Task<List<TEntity>> SearchByName(string searchString)
    {
        return await DbContext.Set<TEntity>()
            .Where(e => e.Name.ToUpper().Equals(searchString.ToUpper())).ToListAsync();
    }
    
    public async Task<TEntity> GetById(TComparable id)
    {
        return await DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Id.Equals(id)) ?? new TEntity();
    }
    public async Task<TEntity> Add(TEntity entity)
    {
        await using var transaction = await DbContext.Database.BeginTransactionAsync();
        
        var newEntity = (await DbContext.Set<TEntity>().AddAsync(entity)).Entity;
        await DbContext.SaveChangesAsync();
        await transaction.CommitAsync();
        return newEntity;
    }
    
    public async Task<TEntity> Update(TEntity entity)
    {
        await using var transaction = await DbContext.Database.BeginTransactionAsync();
        var updatedEntity = DbContext.Set<TEntity>().Update(entity).Entity;
        await DbContext.SaveChangesAsync();
        await transaction.CommitAsync();
        return updatedEntity;
    }
    public async Task<int> Delete(TComparable id)
    {
        await using var transaction = await DbContext.Database.BeginTransactionAsync();
        var entity = await GetById(id);
        entity.IsActive = false;
        DbContext.Set<TEntity>().Update(entity);
        var returnValue = DbContext.SaveChangesAsync();
        await transaction.CommitAsync();

        return returnValue.Result;
    }


}
