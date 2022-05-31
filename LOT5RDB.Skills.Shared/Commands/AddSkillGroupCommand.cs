using LOT5RDB.Skills.Shared.Models;
using LOT5RDB.Skills.Shared.Queries;
using MediatR;

namespace LOT5RDB.Skills.Shared.Commands;

public class AddSkillGroupCommand : IRequest<SkillGroupModel>
{
    public AddSkillGroupCommand(SkillGroupModel newSkillGroupModle)
    {
        NewSkillGroupModle = newSkillGroupModle;
    }
    public SkillGroupModel NewSkillGroupModle { get; set; }
}
