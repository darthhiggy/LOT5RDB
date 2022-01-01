using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOT5RDB.Core.Shared.DataObjects
{
    public class Ranges
    {

        public int MinRange { get; set; }
        public int MaxRange { get; set; }

        public Ranges(int minRange, int maxRange)
        {
            MinRange = minRange;
            MaxRange = maxRange;
        }

        public override string ToString()
        {
            return MinRange == MaxRange ? $"{MinRange}" : $"{MinRange}-{MaxRange}";
        }
    }
}
