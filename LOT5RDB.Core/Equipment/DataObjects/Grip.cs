using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOT5RDB.Core.Equipment.DataObjects
{
    public class Grip
    {
        public int Id { get; set; }
        public GripTypes GripType { get; set; } = GripTypes.Unknown;
        public string Bonus { get; set; } = string.Empty;
        public string ExtraDescription { get; set; } = string.Empty;
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();
        public int WeaponId { get; set; }
        public override string ToString()
        {
            return $"{GripType}{ExtraDescription}: {Bonus}";
        }
    }
}
