using System.Reflection.Metadata.Ecma335;
using LOT5RD.Skills.Models;
using LOT5RDB.Core.Shared.DataObjects;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LOT5RD.Equipment.Models;

public class WeaponModel
{
    public int Id { get; set; } = 0;
    public WeaponCategories Category { get; set; } = WeaponCategories.Uncategorised;
    public string Name { get; set; } = String.Empty;
    public SkillModel Skill { get; set; } = new SkillModel();
    public Ranges Range { get; set; } = new Ranges(0, 0);
    public int BaseDamage { get; set; } = 0;
    public int Deadliness { get; set; } = 0;
    public List<Grip> Grips { get; set; } = new List<Grip>();
    public List<ItemQualityModel> Qualities { get; set; } = new List<ItemQualityModel>();
    public int Rarity { get; set; } = 0;
    public Price Price { get; set; } = new Price(0);
    public Guid DescriptionId { get; set; } = new Guid();
}
