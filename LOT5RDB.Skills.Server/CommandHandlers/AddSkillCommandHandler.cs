using LOT5RDB.Skills.Server.BaseClasses;
using LOT5RDB.Skills.Shared.Commands;
using LOT5RDB.Skills.Shared.Interfaces;
using LOT5RDB.Skills.Shared.Models;

namespace LOT5RDB.Skills.Server.CommandHandlers;

public class AddSkillCommandHandler : BaseSkillHandler<AddSkillCommand, SkillModel>
{

    public AddSkillCommandHandler(ISkillRepository skillRepository) : base(skillRepository)
    {
    }

    public override async Task<SkillModel> Handle(AddSkillCommand request, CancellationToken cancellationToken) =>
        await SkillRepository.Add(request.NewSkillModel);
}
