using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Largest palindrome product
Problem 4
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two 3-digit numbers.
Answer: 906609  
 */


namespace project_euler_cs
{
    class Euler_4
    {
        public void euler4()
        {
            List<int> answers = new List<int>();
            int[] highs = { 0, 0 };
            for (int y = 100; y<1000; y++)
            {
                for (int x = 100; x < 1000; x++)
                {
                    int theProduct = (x * y);
                    string sProduct = theProduct.ToString();
                    //Console.WriteLine(sProduct.Length);
                    if (sProduct == StringHelper.ReverseString(sProduct))
                    {
                        //Console.WriteLine(sProduct + " is a Palindrome number.");
                        answers.Add(theProduct);
                    }
                }
            }
            Console.WriteLine("The highest (answer) is " + answers.Max());
        }
    }
}
