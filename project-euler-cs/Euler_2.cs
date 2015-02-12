using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_cs
{
    class Euler_2
    {
        public void euler2()
        {
            int newy = 0, startx = 1, starty = 2, answer = 2;
            while (starty < 4000000)
            {
                newy = startx + starty;
                startx = starty;
                starty = newy;
                if (starty % 2 == 0)
                {
                    answer += starty;
                }
            }

            Console.WriteLine("The answer is " + answer);
        }
    }
}
