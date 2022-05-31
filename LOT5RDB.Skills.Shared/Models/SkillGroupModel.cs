using LOT5RDB.Core.Shared.DataObjects;
using LOT5RDB.Core.Shared.Interfaces;
using Newtonsoft.Json;

namespace LOT5RDB.Skills.Shared.Models;

public class SkillGroupModel : BaseEntity<int>
{
    public SkillGroupModel()
    {

    }
    public SkillGroupModel(int id)
    {
        Id = id;
    }
    [JsonConstructor]
    public SkillGroupModel(int id, string name, Guid descriptionId)
    {
        Id = id;
        Name = name;
        DescriptionId = descriptionId;
        Skills = new List<SkillModel>();
    }

    public Guid DescriptionId { get; set; }
    public List<SkillModel> Skills { get; set; }
}
