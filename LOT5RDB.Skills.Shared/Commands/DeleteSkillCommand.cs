using MediatR;

namespace LOT5RDB.Skills.Shared.Commands;

public class DeleteSkillCommand : IRequest<int>
{
    public DeleteSkillCommand(int id)
    {
        Id = id;
    }
    public int Id { get; set; }
}
