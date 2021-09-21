using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class EqualizeTheArray
    {
        public int EqualizeTheArraySol(List<int> arr)
        {
            int repeatedNum;
            int repeatedCount = 0;
            int maxRepeatedNum;
            int maxRepatedCount = 0;
            bool firstComing = true;

            arr.Sort();

            for(int i = 0; i < arr.Count - 1; i++)
            {
                if(arr[i] == arr[i+1])
                {
                    repeatedNum = arr[i];
                    repeatedCount++;

                    if (firstComing)
                    {
                        repeatedCount++;
                        firstComing = false;
                    }
                        

                    if (repeatedCount > maxRepatedCount)
                    {
                        maxRepeatedNum = repeatedNum;
                        maxRepatedCount = repeatedCount;
                    } 

                    
                }
                else
                {
                    repeatedCount = 0;
                    firstComing = true;
                }
            }

            if (maxRepatedCount == 0)
                return arr.Count - 1;

            return arr.Count - maxRepatedCount; 
        }
    }
}
