using LOT5RDB.Skills.Server.BaseClasses;
using LOT5RDB.Skills.Shared.Interfaces;
using LOT5RDB.Skills.Shared.Models;
using LOT5RDB.Skills.Shared.Queries;

namespace LOT5RDB.Skills.Server.Queries;

public class GetSkillByIdQueryHandler : BaseSkillHandler<GetSkillByIdQuery, SkillModel>
{

    public GetSkillByIdQueryHandler(ISkillRepository skillRepository) : base(skillRepository)
    {
    }
    
    public override async Task<SkillModel> Handle(GetSkillByIdQuery request, CancellationToken cancellationToken) => await SkillRepository.GetById(request.Id);
}
