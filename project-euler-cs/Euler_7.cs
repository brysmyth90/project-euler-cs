using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_cs
{
    class Euler_7
    {
        /*
        10001st prime
        Problem 7
        By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        What is the 10 001st prime number?
        Answer: 
        104743
         */
        public void euler7()
        {
            DateTime started = DateTime.Now;
            long i = 1;
            List<long> primes = new List<long>();
            while (primes.Count <10001)
            {
                if (PrimeHelper.primeCheck(i))
                {
                    primes.Add(i);
                }
                i++;
            }
            Console.WriteLine("Answer is "+ primes[primes.Count -1 ]);
            /*
            foreach (long p in primes)
            {
                Console.WriteLine(p);
            }
             */
            Console.WriteLine("Took " + (DateTime.Now).Subtract(started).TotalSeconds + " seconds.");
        }
    }
}