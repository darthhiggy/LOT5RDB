using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOT5RDB.Core.Shared.DataObjects
{
    public class Price
    {
        public Price(int amount)
        {
            Amount = amount;
        }
        public int Amount { get; set; } = 0;
        public int Zini => Amount - (Koku * 100) - (Bu * 10);
        public int Bu => (Amount - (Koku * 100)) % 10;

        public int Koku => Amount % 100;

        public override string ToString()
        {
            string returnString = "";
            if(Koku > 0)
            {
                returnString += $"{Koku} koku ";
            }
            if(Bu > 0)
            {
                returnString += $"{Bu} bu ";
            }
            if(Zini > 0)
            {
                returnString += $"{Zini} zini"; 
            }

            return returnString;
        }
    }
}
