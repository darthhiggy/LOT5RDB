using LOT5RDB.Data.EquipmentDb;
using LOT5RDB.Skills.Shared.Interfaces;
using LOT5RDB.Skills.Shared.Models;

namespace LOT5RDB.Data.Repositories.SkillRepos;

public class SkillRepository : BaseRepository<SkillModel, int>, ISkillRepository
{

    public SkillRepository(EquipmentDbContext dbContext) : base(dbContext)
    {
    }
}
