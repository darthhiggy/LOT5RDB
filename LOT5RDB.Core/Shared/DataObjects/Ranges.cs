using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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

        public Ranges(string values)
        {
            var split = values.Split('-');
            if (split.Length == 2)
            {
                MinRange = int.Parse(split[0]);
                MaxRange = int.Parse(split[1]);
            }
            else
            {
                MinRange = 0;
                MaxRange = 0;
            }
        }

        public override string ToString()
        {
            return MinRange == MaxRange ? $"{MinRange}" : $"{MinRange}-{MaxRange}";
        }
    }
}
