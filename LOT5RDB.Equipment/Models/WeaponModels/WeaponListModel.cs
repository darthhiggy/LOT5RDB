using LOT5RDB.Skills.Models;
using LOT5RDB.Core.Shared.DataObjects;

namespace LOT5RDB.Equipment.Models.WeaponModels;

public class WeaponListModel
{
    public int Id { get; set; } = 0;
    public WeaponCategories Category { get; set; } = WeaponCategories.Uncategorised;
    public string Name { get; set; } = string.Empty;
    public SkillModel Skill { get; set; } = new SkillModel();
    public int Rarity { get; set; }
    public Price Price { get; set; } = new(0);
}
