using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class ServiceLane
    {
        public List<int> ServiceLaneSol(int n, List<List<int>> cases, List<int> width)
        {
            int minWidth = Int32.MaxValue;
            int temp;


            List<int> maxSizeOfVehicle = new List<int>();

            for(int i = 0; i < cases.Count; i++)
            {
                for(int j = cases[i][0]; j <= cases[i][1]; j++ )
                {
                    temp = width[j];
                    if(temp < minWidth)
                    {
                        minWidth = temp;
                    }
                }

                maxSizeOfVehicle.Add(minWidth);
                minWidth = Int32.MaxValue;
            }

            return maxSizeOfVehicle;
        }
    }
}
