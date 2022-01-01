using LOT5RDB.Core.Shared.DataObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOT5RDB.Core.Equipment.DataObjects
{
    public class Weapon
    {
        public int Id { get; set; }
        public WeaponCategories Category { get; set; }
        public string Name { get; set; }
        public string Skill { get; set; }
        public Ranges Range { get; set; } 
        public int BaseDamage { get; set; }
        public int Deadliness { get; set; }
        public List<Grip> Grips { get; set; } = new List<Grip>();
        public List<WeaponQuality> Qualities { get; set; } = new List<WeaponQuality>();
        public int Rarity { get; set; }
        public Price Price { get; set; }
        public string Description { get; set; }

    }
}
