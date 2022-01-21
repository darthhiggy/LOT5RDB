using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOT5RDB.Core.Equipment.DataObjects
{
    public class ItemQuality
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();
    }
}
