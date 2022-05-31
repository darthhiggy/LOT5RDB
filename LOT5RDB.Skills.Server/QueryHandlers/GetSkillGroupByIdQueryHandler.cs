using LOT5RDB.Skills.Server.BaseClasses;
using LOT5RDB.Skills.Shared.Interfaces;
using LOT5RDB.Skills.Shared.Models;
using LOT5RDB.Skills.Shared.Queries;

namespace LOT5RDB.Skills.Server.Queries;

public class GetSkillGroupByIdQueryHandler : BaseSkillGroupHandler<GetSkillGroupByIdQuery, SkillGroupModel>
{

    public GetSkillGroupByIdQueryHandler(ISkillGroupRepository skillGroupRepository) : base(skillGroupRepository)
    {
    }

    public override async Task<SkillGroupModel> Handle(GetSkillGroupByIdQuery request, CancellationToken cancellationToken) =>
        await SkillGroupRepository.GetById(request.Id);
}
