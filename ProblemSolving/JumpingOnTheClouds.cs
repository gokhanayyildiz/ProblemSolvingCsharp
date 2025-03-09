using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class JumpingOnTheClouds
    {
        public int JumpingOnTheCloudsSol(List<int> c)
        {
            int shortestWay = 0;

            for(int i = 1; i+1 <= c.Count; i++)
            {
                

                if(i+1 != c.Count )
                {
                    if (c[i + 1] == 0)
                    {
                        shortestWay++;
                        i++;
                    }
                    else
                    {
                        shortestWay++;
                    }
                }
                else
                {
                    shortestWay++;
                }
            }

            return shortestWay;
        }
    }
}
