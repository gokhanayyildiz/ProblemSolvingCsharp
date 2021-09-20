using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class CutTheSticks
    {
        public List<int> CutTheSticksSol(List<int> arr)
        {
            List<int> result = new List<int>();
            List<int> temp = new List<int>(arr);
            
            arr.Sort();
            temp.Sort();

            

            while(arr.Count != 0)
            {
                result.Add(arr.Count);
                for (int i = 0; i < arr.Count; i++)
                {
                    arr[i] -= temp[0];
                }

                for (int i = 0; i < arr.Count; i++)
                { 
                    if (arr[i] == 0)
                    {
                        arr.Remove(arr[i]);
                        i = -1;
                    }
                }
                arr.Sort();
                temp = new List<int>(arr);
            }



            return result;
        }
    }
}
