using LOT5RDB.Skills.Server.BaseClasses;
using LOT5RDB.Skills.Shared.Commands;
using LOT5RDB.Skills.Shared.Interfaces;
using LOT5RDB.Skills.Shared.Models;

namespace LOT5RDB.Skills.Server.CommandHandlers;

public class UpdateSkillGroupCommandHandler : BaseSkillGroupHandler<UpdateSkillGroupCommand, SkillGroupModel>
{

    public UpdateSkillGroupCommandHandler(ISkillGroupRepository skillGroupRepository) : base(skillGroupRepository)
    {
    }

    public override async Task<SkillGroupModel> Handle(UpdateSkillGroupCommand request, CancellationToken cancellationToken) =>
        await SkillGroupRepository.Update(request.UpdatedSkillGroupModel);
}
