using LOT5RDB.Core.Shared.DataObjects;
using LOT5RDB.Core.Shared.Interfaces;
using Newtonsoft.Json;

namespace LOT5RDB.Skills.Shared.Models;

public class SkillModel : BaseEntity<int>
{
    public SkillModel()
    {
        Name = string.Empty;
        SkillGroup = new SkillGroupModel();
    }
    public SkillModel(string name, SkillGroupModel skillGroup)
    {
        Name = name;
        SkillGroup = skillGroup;

    }

    public SkillModel(int id, string name, SkillGroupModel skillGroup)
    {
        Id = id;
        Name = name;
        SkillGroup = skillGroup;
    }

    [JsonConstructor]
    public SkillModel(int id, string name, Guid descriptionId, int skillGroupId, SkillGroupModel skillGroup)
    {
        Id = id;
        Name = name;
        DescriptionId = descriptionId;
        SkillGroupId = skillGroupId;
        SkillGroup = skillGroup;
    }
    public Guid DescriptionId { get; set; }
    public int SkillGroupId { get; set; }
    public SkillGroupModel SkillGroup { get; set; }
}
