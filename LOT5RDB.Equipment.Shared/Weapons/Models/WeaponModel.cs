using LOT5RDB.Core.Shared.DataObjects;
using LOT5RDB.Core.Shared.Interfaces;
using LOT5RDB.Equipment.Shared.ItemQualities.Models;
using LOT5RDB.Skills.Shared.Models;

namespace LOT5RDB.Equipment.Shared.Weapons.Models;

public class WeaponModel : BaseEntity<int>
{
    public WeaponModel()
    {
        Category = WeaponCategories.Uncategorised;
        Name = String.Empty;
    }
    
    public WeaponCategories Category { get; set; }
    public int SkillId { get; set; }
    public SkillModel Skill { get; set; }
    public Ranges Range { get; set; }
    public int BaseDamage { get; set; }
    public int Deadliness { get; set; }
    public List<Grip> Grips { get; set; }
    public List<ItemQualityModel> Qualities { get; set; }
    public int Rarity { get; set; } = 0;
    public Price Price { get; set; }
    public Guid DescriptionId { get; set; }
}
