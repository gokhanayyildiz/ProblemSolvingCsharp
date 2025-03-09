using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class SaveThePrisoner
    {
        public int SolSaveThePrisoner(int n, int m, int s)
        {
            int tempChair = s;
            int k;

            if(m <= n)
            {
                for(int i = 2; i <= m; i++)
                {
                    if (tempChair == n)
                        tempChair = 0;

                    tempChair++;
                }
            }
            else
            {
                k = (m % n);

                tempChair += (k-1);
            }

            return tempChair;
        }
    }
}
