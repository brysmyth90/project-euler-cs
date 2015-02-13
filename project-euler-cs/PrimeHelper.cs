using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_cs
{
    static class PrimeHelper
    {
        public static bool primeCheck(long x)
        {
            for (long checker = 2; checker < Math.Sqrt(x) + 1; checker++)
            {
                if ((x % checker) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
