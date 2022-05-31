using LOT5RDB.Core.Shared.DataObjects;
using LOT5RDB.Skills.Shared.Models;

namespace LOT5RDB.Equipment.Shared.Models.WeaponModels;

public class WeaponListModel
{
    public int Id { get; set; } = 0;
    public WeaponCategories Category { get; set; } = WeaponCategories.Uncategorised;
    public string Name { get; set; } = string.Empty;
    public SkillModel Skill { get; set; }
    public int Rarity { get; set; }
    public Price Price { get; set; } = new(0);
}
