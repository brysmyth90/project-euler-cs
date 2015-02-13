using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_cs
{
    class Euler_6
    {
        /*
        Sum square difference
        Problem 6
        The sum of the squares of the first ten natural numbers is,
        1^2 + 2^2 + ... + 10^2 = 385
        The square of the sum of the first ten natural numbers is,
        (1 + 2 + ... + 10)^2 = 55^2 = 3025
        Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        Answer: 
        25164150 
         */
        public void euler6()
        {
            DateTime started = DateTime.Now;
            long sumSq = 0;
            long sqSum = 0;
            long sum = 0;
            for (int x = 0; x <= 100; x++)
            {
                sumSq += (long)Math.Pow(x, 2);
            }
            Console.WriteLine(sumSq);
            for (int x = 0; x <= 100; x++)
            {
                sum += x;
            }
            sqSum = (long)Math.Pow(sum, 2);
            Console.WriteLine(sqSum);
            long d = sumSq - sqSum;
            long answer = Math.Abs(d);
            Console.WriteLine("The answer is " + answer);
            Console.WriteLine("Took " + (DateTime.Now).Subtract(started).TotalSeconds + " seconds.");
        }
    }
}
