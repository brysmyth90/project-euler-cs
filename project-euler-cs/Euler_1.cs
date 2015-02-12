using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.

*/

namespace project_euler_cs
{
    public class Euler_1
    {
        public void euler1()
        {
            Console.WriteLine("Starting");
            int answer = 0;
            for (int x = 1; x < 1000; x++)
            {
                if ( x%3==0 || x%5==0)
                {
                    answer += x;
                }
            }

            Console.WriteLine("The answer is " + answer);

        }
    }
}
