using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class JumpingOnTheCloudsRevisited
    {
        public int JumpingOnTheCloudsRevisitedSol(int[] c, int k)
        { 
            int energy = 100;
            int temp = 0;
             
            for (int i = k; energy > 0; i+=k)
            {
                if (i >= c.Length)
                {
                    i = i - c.Length;
                }
 
                if (c[i] == 0)
                {
                    energy--;
                }
                else
                {
                    energy -= 3;
                }
 
                if (i == 0)
                {
                    temp = energy;
                    energy = -1;
                } 
            }
             
            return temp;
        }
    }
}
