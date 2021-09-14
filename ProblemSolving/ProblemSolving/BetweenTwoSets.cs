using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class BetweenTwoSets
    {
        public int BetweentTwoSetsSol(List<int> a, List<int> b)
        {
            int factor;
            int i = 2;
            int count = 0;
            int temp = 0;

            List<int> c = new List<int>();

            a.Sort();
            b.Sort();






            if(a[1]%a[0]==0)
            {
                c.Add(a[1]);
                factor = a[1];
            }
            else
            {
                c.Add(a[0] * a[1]);
                factor = a[0] * a[1];
            }
              
            while(factor < b[0])
            {
                factor = c[0] * i;
                c.Add(c[0]*i);
                i++;
            }

            for(int j=0; j < c.Count; j++)
            {
                for(int k = 0; k < b.Count; k++)
                {
                    if(b[k] % c[j] == 0)
                    {
                        temp++;
                    }
                }
                if (temp == b.Count)
                    count++;

                temp = 0;
            }

            return count;
        }
    }
}
