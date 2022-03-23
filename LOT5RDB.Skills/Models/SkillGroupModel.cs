namespace LOT5RDB.Skills.Models;

public class SkillGroupModel
{
    public SkillGroupModel()
    {

    }
    public SkillGroupModel(int id)
    {
        Id = id;
    }

    public int Id { get; set; } = 0;
    public string Name { get; set; } = "";
    public Guid DescriptionId { get; set; } = new();
    public List<SkillModel> Skills { get; set; } = new();
}
