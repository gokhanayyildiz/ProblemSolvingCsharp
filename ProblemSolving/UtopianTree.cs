using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class UtopianTree
    {
        public int SolUtopianTree(int n)
        {
            int height = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)//Spring
                {
                    height *= 2;
                }
                else
                {
                    height += 1;
                }
            }

            return height;
        }
    }
}
