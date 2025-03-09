using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class CircularArrayRotation
    {
        public List<int> CircularArrayRotationSol(List<int> a, int k, List<int> queries)
        {
            List<int> rotation = new List<int>(a);
            List<int> result = new List<int>(queries);
            int temp;
            int value;

            for(int i = 0; i < k; i++)
            {
                temp = a[a.Count - 1];
                rotation[0] = temp;
                for (int j = 1; j < a.Count; j++)
                {
                    rotation[j] = a[j - 1];
                }

               a = new List<int>(rotation);
            }



            for(int i = 0; i < queries.Count; i++)
            {
                value = queries[i];
                result[i] = rotation[value]; 
            }

            return result;
        }
    }
}
