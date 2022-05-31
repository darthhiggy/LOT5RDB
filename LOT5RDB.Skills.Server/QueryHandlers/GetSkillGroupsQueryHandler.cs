using LOT5RDB.Skills.Server.BaseClasses;
using LOT5RDB.Skills.Shared.Interfaces;
using LOT5RDB.Skills.Shared.Models;
using LOT5RDB.Skills.Shared.Queries;

namespace LOT5RDB.Skills.Server.Queries;

public class GetSkillGroupsQueryHandler : BaseSkillGroupHandler<GetSkillGroupsQuery, List<SkillGroupModel>>
{

    public GetSkillGroupsQueryHandler(ISkillGroupRepository skillGroupRepository) : base(skillGroupRepository)
    {
    }

    public override async Task<List<SkillGroupModel>> Handle(GetSkillGroupsQuery request, CancellationToken cancellationToken) =>
        string.IsNullOrWhiteSpace(request.SearchString) 
            ? await SkillGroupRepository.GetAllAsync() 
            : await SkillGroupRepository.SearchByName(request.SearchString);
}
