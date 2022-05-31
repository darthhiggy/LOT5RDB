using LOT5RDB.Skills.Shared.Models;
using MediatR;

namespace LOT5RDB.Skills.Shared.Commands;

public class UpdateSkillGroupCommand : IRequest<SkillGroupModel>
{
    public UpdateSkillGroupCommand(SkillGroupModel updatedSkillGroupModel)
    {
        UpdatedSkillGroupModel = updatedSkillGroupModel;
    }
    public SkillGroupModel UpdatedSkillGroupModel { get; set; }
}
