using LOT5RDB.Core.Shared.DataObjects;
using LOT5RDB.Core.Shared.Interfaces;
using LOT5RDB.Data.DescriptionsDb;
using Microsoft.EntityFrameworkCore;

namespace LOT5RDB.Data.Repositories.DescriptionRepos;

public class DescriptionRepository : IDescriptionRepo
{
    private readonly DescriptionsDbContext _dbContext;
    public DescriptionRepository(DescriptionsDbContext dbContext)
    {
        _dbContext = dbContext;

    }
    public async Task<LongText> GetLongTextByIdAsync(Guid id)
    {
        return await _dbContext.Descriptions.FirstOrDefaultAsync(e => e.Id == id) ?? new LongText();
    }
    public async Task<LongText> AddLongTextAsync(LongText longText)
    {
        await using var transaction = await _dbContext.Database.BeginTransactionAsync();
        
        var newEntity = (await _dbContext.Descriptions.AddAsync(longText)).Entity;
        await _dbContext.SaveChangesAsync();
        await transaction.CommitAsync();
        return newEntity;
    }
    public async Task<LongText> UpdateLongTextAsync(LongText longText)
    {
        await using var transaction = await _dbContext.Database.BeginTransactionAsync();
        
        var newEntity = _dbContext.Descriptions.Update(longText).Entity;
        await _dbContext.SaveChangesAsync();
        await transaction.CommitAsync();
        return newEntity;
    }
    public async Task<int> DeleteLongTextAsync(Guid id)
    {
        await using var transaction = await _dbContext.Database.BeginTransactionAsync();
        var entity = await GetLongTextByIdAsync(id);
        _dbContext.Descriptions.Remove(entity);
        var returnValue = _dbContext.SaveChangesAsync();
        await transaction.CommitAsync();

        return returnValue.Result;
    }

}
