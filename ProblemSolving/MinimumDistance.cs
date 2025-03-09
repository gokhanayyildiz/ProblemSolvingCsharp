using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class MinimumDistance
    {
        public int MinimumDistanceSol(List<int> a)
        {
            int minimumDistance = Int32.MaxValue;
            int temp;

            for(int i = 0; i < a.Count ; i++)
            {
                for(int j = i + 1; j < a.Count; j++ )
                {
                    if(a[i] != a[j])
                    {
                        continue;
                    }
                    else
                    {
                        temp = j - i;
                        if(temp < minimumDistance)
                        {
                            minimumDistance = temp;
                        }
                    }
                }
            }

            if (minimumDistance == Int32.MaxValue)
                return -1;
            else
                return minimumDistance;
            
        }
    }
}
