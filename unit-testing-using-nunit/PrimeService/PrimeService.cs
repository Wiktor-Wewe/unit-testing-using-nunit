using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_testing_using_nunit.PrimeService
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate <= 1)
            {
                return false;
            }
            
            for(int i = 2; i < Math.Sqrt(candidate); i++)
            {
                if( candidate % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
