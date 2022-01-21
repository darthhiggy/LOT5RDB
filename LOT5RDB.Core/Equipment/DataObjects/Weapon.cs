using LOT5RDB.Core.Shared.DataObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOT5RDB.Core.Skills.DataObjects;

namespace LOT5RDB.Core.Equipment.DataObjects
{
    public class Weapon
    {
        public Weapon()
        {
            
        }

        public int Id { get; set; } = 0;
        public WeaponCategories Category { get; set; }
        public string Name { get; set; } = "";
        public int SkillId { get; set; } = 0;
        public Skill Skill { get; set; } = new Skill();
        public Ranges Range { get; set; } = new Ranges(0, 0);
        public int BaseDamage { get; set; } = 0;
        public int Deadliness { get; set; } = 0;
        public List<Grip> Grips { get; set; } = new List<Grip>();
        public List<ItemQuality> Qualities { get; set; } = new List<ItemQuality>();
        public int Rarity { get; set; }
        public Price Price { get; set; } = new Price(0);
        public string Description { get; set; } = string.Empty;

    }
}
