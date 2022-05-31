using LOT5RDB.Skills.Shared.Models;
using MediatR;

namespace LOT5RDB.Skills.Shared.Queries;

public class GetSkillGroupByIdQuery : IRequest<SkillGroupModel>
{
    public GetSkillGroupByIdQuery(int id)
    {
        Id = id;
    }
    public int Id { get; set; }
}
