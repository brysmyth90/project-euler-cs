using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_cs

/*
Largest prime factor
Problem 3
The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?
Answer: 
6857  
*/


{
    class Euler_3
    {
        public void euler3()
        {
            DateTime started = DateTime.Now;
            bool foundAnswer = false;
            long startNum = 600851475143;
            double startSearch = Math.Sqrt(startNum)+1.0;
            //double startSearch = startNum*0.5 + 1.0;
            long startSearchL = (long)startSearch;
            Console.WriteLine("The start is " + startSearchL);
            while (!foundAnswer)
            {
                if (startNum % startSearchL == 0) // have a factor - is it prime?
                {
                    if (primeCheck(startSearchL))
                    {
                        Console.WriteLine("The answer is " + startSearchL);
                        Console.WriteLine("Took " + (DateTime.Now).Subtract(started).TotalSeconds + " seconds.");
                        foundAnswer = true;
                    }
                    else //the factor was no good so need to drop another number down.
                    {
                        startSearchL -= 1;
                    }
                }
                else
                {
                    //Console.WriteLine("Wasn't a factor so subtracting one from startSearchL");
                    startSearchL -= 1;
                    //Console.WriteLine("It's now " + startSearchL);
                }
            }

        }




        bool primeCheck(long x)
        {
            //double tester = Math.Sqrt(x);
            //long testerL = (long)tester;
            //Console.WriteLine("In primeCheck testing " + x);
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
