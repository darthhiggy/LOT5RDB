using LOT5RDB.Skills.Shared.Models;
using MediatR;

namespace LOT5RDB.Skills.Shared.Commands;

public class AddSkillCommand : IRequest<SkillModel>
{

    public AddSkillCommand(SkillModel newSkillModel)
    {
        NewSkillModel = newSkillModel;
    }
    public SkillModel NewSkillModel { get; set; }
}
