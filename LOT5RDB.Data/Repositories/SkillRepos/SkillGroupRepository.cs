using LOT5RDB.Data.EquipmentDb;
using LOT5RDB.Skills.Shared.Interfaces;
using LOT5RDB.Skills.Shared.Models;

namespace LOT5RDB.Data.Repositories.SkillRepos;

public class SkillGroupRepository : BaseRepository<SkillGroupModel, int>, ISkillGroupRepository
{

    public SkillGroupRepository(EquipmentDbContext dbContext) : base(dbContext)
    {
    }
}
