using LOT5RDB.Skills.Server.BaseClasses;
using LOT5RDB.Skills.Shared.Interfaces;
using LOT5RDB.Skills.Shared.Models;
using LOT5RDB.Skills.Shared.Queries;

namespace LOT5RDB.Skills.Server.Queries;

public class GetSkillsQueryHandler : BaseSkillHandler<GetSkillsQuery, List<SkillModel>>
{

    public GetSkillsQueryHandler(ISkillRepository skillRepository) : base(skillRepository)
    {
    }

    public override async Task<List<SkillModel>> Handle(GetSkillsQuery request, CancellationToken cancellationToken)
    {
        return string.IsNullOrWhiteSpace(request.SearchString)
            ? await SkillRepository.GetAllAsync()
            : await SkillRepository.SearchByName(request.SearchString);
    }
}
