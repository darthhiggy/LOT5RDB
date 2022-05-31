using LOT5RDB.Skills.Server.BaseClasses;
using LOT5RDB.Skills.Shared.Commands;
using LOT5RDB.Skills.Shared.Interfaces;
using LOT5RDB.Skills.Shared.Models;

namespace LOT5RDB.Skills.Server.CommandHandlers;

public class AddSkillGroupCommandHandler : BaseSkillGroupHandler<AddSkillGroupCommand, SkillGroupModel>
{

    public AddSkillGroupCommandHandler(ISkillGroupRepository skillGroupRepository) : base(skillGroupRepository)
    {
    }

    public override async Task<SkillGroupModel> Handle(AddSkillGroupCommand request, CancellationToken cancellationToken) =>
        await SkillGroupRepository.Add(request.NewSkillGroupModle);
}
