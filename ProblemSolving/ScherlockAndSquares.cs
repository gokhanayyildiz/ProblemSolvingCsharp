using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class ScherlockAndSquares
    {
        public int ScherlockAndSquaresSol(int a, int b)
        {
            int count = 0;
            int i = 1;
 
            while (i * i < a)
            {
                i++;
            }
 
            while(i * i <= b)
            {
                count++;
                i++;
            }
     
            return count;
        }
    }
}
