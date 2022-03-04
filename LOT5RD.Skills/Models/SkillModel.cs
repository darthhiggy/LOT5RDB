namespace LOT5RD.Skills.Models;

public class SkillModel
{
    public SkillModel()
    {
        
    }

    public SkillModel(int id)
    {
        Id = id;
    }

    public int Id { get; set; } = 0;
    public string Name { get; set; } = "";
    public Guid DescriptionId { get; set; } = new Guid();
    public int SkillGroupId { get; set; } = 0;
    public SkillGroupModel SkillGroup { get; set; } = new SkillGroupModel();
}
