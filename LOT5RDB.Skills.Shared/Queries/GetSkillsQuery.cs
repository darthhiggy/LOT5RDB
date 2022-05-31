using LOT5RDB.Skills.Shared.Models;
using MediatR;

namespace LOT5RDB.Skills.Shared.Queries;

public class GetSkillsQuery : IRequest<List<SkillModel>>
{
    public GetSkillsQuery(string searchString = "")
    {
        SearchString = searchString;
    }
    public string SearchString { get; set; }
}
