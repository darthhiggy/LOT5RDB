using LOT5RDB.Skills.Shared.Models;
using MediatR;

namespace LOT5RDB.Skills.Shared.Queries;

public class GetSkillGroupsQuery : IRequest<List<SkillGroupModel>>
{

    public GetSkillGroupsQuery(string searchString = "")
    {
        SearchString = searchString;
    }
    public string SearchString { get; set; }
}
