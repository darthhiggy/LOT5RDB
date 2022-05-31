using LOT5RDB.Skills.Shared.Models;
using MediatR;

namespace LOT5RDB.Skills.Shared.Queries;

public class GetSkillByIdQuery : IRequest<SkillModel>
{
    public GetSkillByIdQuery(int id)
    {
        Id = id;
    }
    public int Id { get; set; }
}
