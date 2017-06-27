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
            var possiblePrime = 2;

            if (num < 2)
            {
                return factList;
            }

            while (num > 1)
            {
                while (num % possiblePrime == 0)
                {
                    factList.Add(possiblePrime);
                    num = num / possiblePrime;
                }
                possiblePrime++;
            }

            return factList;
        }
    }
}
