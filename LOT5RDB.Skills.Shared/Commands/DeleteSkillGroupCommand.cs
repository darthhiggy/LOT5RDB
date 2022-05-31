using LOT5RDB.Skills.Shared.Models;
using MediatR;

namespace LOT5RDB.Skills.Shared.Commands;

public class DeleteSkillGroupCommand : IRequest<SkillGroupModel>
{
    public DeleteSkillGroupCommand(int id)
    {
        Id = id;
    }
    public int Id { get; set; }
}
