using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class MaximizingXOR
    {
        public int MaximizingXORSol(int l, int r)
        {
            int maxValue = Int32.MinValue;
            int tempMax;

            for(int i = l; i <= r; i++)
            {
                for(int j = i; j <= r; j++)
                {
                    tempMax = GetXORResult(i, j);

                    if (tempMax > maxValue)
                        maxValue = tempMax;
                }
            }
 
            return maxValue;
        }

        public int GetXORResult(int i, int j)
        {
            return (i + j - (2 * (i & j)));
        }
    }
}
