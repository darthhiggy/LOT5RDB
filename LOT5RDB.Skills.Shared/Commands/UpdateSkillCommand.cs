using LOT5RDB.Skills.Shared.Models;
using MediatR;

namespace LOT5RDB.Skills.Shared.Commands;

public class UpdateSkillCommand : IRequest<SkillModel>
{
    public UpdateSkillCommand(SkillModel updatedSKillModel)
    {
        UpdatedSKillModel = updatedSKillModel;
    }
    public SkillModel UpdatedSKillModel { get; set; }
}
