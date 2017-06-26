using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class PrimeFact
    {
        public List<int> Factor(int num)
        {
            List<int> factList = new List<int>();

            if (num < 2)
            {
                return factList;
            }
            if (num == 2)
            {
                factList.Add(2);
            }
            if (num == 3)
            {
                factList.Add(3);
            }

            return factList;
        }
    }
}
