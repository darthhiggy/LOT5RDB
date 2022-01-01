using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOT5RDB.Core.Shared.DataObjects
{
    public class Price
    {
        public int Zini { get; set; } = 0;
        public int Bu { get; set; } = 0;
        public int Koku { get; set; } = 0;
        public override string ToString()
        {
            string returnString = "";
            if(Koku > 0)
            {
                returnString += $"{Koku} koku";
            }
            if(Bu > 0)
            {
                returnString += $"{Bu} bu";
            }
            if(Zini > 0)
            {
                returnString += $"{Zini} zini"; 
            }

            return returnString;
        }
    }
}
