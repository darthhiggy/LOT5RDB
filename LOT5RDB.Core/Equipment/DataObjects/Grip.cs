using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOT5RDB.Core.Equipment.DataObjects
{
    public class Grip
    {
        public GripTypes GripType { get; set; }
        public string Bonus { get; set; }
        public string ExtraDescription { get; set; }
        public override string ToString()
        {
            return $"{GripType}{ExtraDescription}: {Bonus}";
        }
    }
}
