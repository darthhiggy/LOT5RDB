using LOT5RDB.Skills.Models;
using LOT5RDB.Core.Shared.DataObjects;

namespace LOT5RDB.Equipment.Models;

public class WeaponModel
{
    public int Id { get; set; } = 0;
    public WeaponCategories Category { get; set; } = WeaponCategories.Uncategorised;
    public string Name { get; set; } = string.Empty;
    public SkillModel Skill { get; set; } = new();
    public Ranges Range { get; set; } = new(0, 0);
    public int BaseDamage { get; set; } = 0;
    public int Deadliness { get; set; } = 0;
    public List<Grip> Grips { get; set; } = new();
    public List<ItemQualityModel> Qualities { get; set; } = new();
    public int Rarity { get; set; } = 0;
    public Price Price { get; set; } = new(0);
    public Guid DescriptionId { get; set; } = new();
}
