using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class BeautifulTriplets
    {
        public int BeautifulTripletsSol(int d, List<int> arr)
        {
            int tripletCount = 0;
             
            for(int i = 0; i < arr.Count - 2; i++)
            {
                for(int j = i + 1; j < arr.Count - 1; j++)
                {
                    if(arr[j] - arr[i] != d)
                    {
                        continue;
                    }
                    else
                    {
                        for (int k = j + 1; k < arr.Count; k++)
                        {
                            if(arr[k] - arr[j] != d)
                            {
                                continue;
                            }
                            else
                            {
                                if (arr[k] - arr[j] == d && arr[j] - arr[i] == d)
                                    tripletCount++;
                            } 
                        } 
                    }
                }
            }
             
            return tripletCount;
        }
    }
}
