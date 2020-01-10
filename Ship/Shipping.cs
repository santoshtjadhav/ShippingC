using System;
using System.Collections.Generic;
using System.Text;

namespace Ship
{
    public class Shipping
    {
        private int Large = 5;
        private int Small = 1;

        public int CalculatePackages(int items, int LargeNumbers, int SmallNumbers)
        {
            int requiredSmall = 0;
            if (items <= 0 ) 
                return -1;
            if ((LargeNumbers + SmallNumbers) <= 0)
                return -1;
            
            try
            {
                int requiredLarge = items / Large;
                if (requiredLarge >= LargeNumbers)
                    requiredLarge = LargeNumbers;
                int remainItems = items - (LargeNumbers * Large);

                if (remainItems <= SmallNumbers)
                    requiredSmall = remainItems;
                else
                {
                    if (remainItems >= Small * SmallNumbers)
                        return -1;

                    requiredSmall = remainItems / (Small * SmallNumbers);
                }
                return requiredLarge + requiredSmall;
            }
            catch (Exception ex)
            {
                return -1;
            }

            return -1;

        }

    }
}
