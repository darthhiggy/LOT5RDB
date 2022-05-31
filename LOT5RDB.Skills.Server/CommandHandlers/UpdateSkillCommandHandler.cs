using LOT5RDB.Skills.Server.BaseClasses;
using LOT5RDB.Skills.Shared.Commands;
using LOT5RDB.Skills.Shared.Interfaces;
using LOT5RDB.Skills.Shared.Models;

namespace LOT5RDB.Skills.Server.CommandHandlers;

public class UpdateSkillCommandHandler : BaseSkillHandler<UpdateSkillCommand, SkillModel>
{

    public UpdateSkillCommandHandler(ISkillRepository skillRepository) : base(skillRepository)
    {
    }

    public override async Task<SkillModel> Handle(UpdateSkillCommand request, CancellationToken cancellationToken) =>
        await SkillRepository.Update(request.UpdatedSKillModel);
}
