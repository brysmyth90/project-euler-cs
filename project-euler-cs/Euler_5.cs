using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_cs
{
    class Euler_5
    /*
    2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    Answer:232792560 
    */
    {
        public void euler5 ()
        {
            DateTime started = DateTime.Now;
            List<int> divs = new List<int> {11,12,13,14,15,16,17,18,19,20};
            int x = 7;
            bool solved = false;
            while (!solved)
            {
                solved = allDivs(divs, x);
                if (!solved)
                {
                    x++;
                }
            }
            Console.WriteLine("The answer is " + x);
            Console.WriteLine("Took " + (DateTime.Now).Subtract(started).TotalSeconds + " seconds.");
        }



        bool allDivs (List<int> divs, int x)
        //only returns true if it gets to the end after checking that all divs are indeed even.
        {
            foreach(int d in divs)
            {
                if (x%d!=0)
                {
                    return false;
                }
            }
            return true;
        }




    }
}
