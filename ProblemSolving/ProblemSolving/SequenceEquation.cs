using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class SequenceEquation
    {
        public List<int> SequenceEquationSol(List<int> p)
        {
            List<int> temp = new List<int>();

            List<int> result = new List<int>();
            result.Add(0);


            bool isTurnedTwice = true;
            int count = 0;


            for(int i = 0; i < p.Count; i++)
            {
                result.Add(p[i]);
            }

            for(int i = 1; i < result.Count; i++)
            {
                int searchingNumber = i;
                int j = 0;
                while(isTurnedTwice)
                {
                    j++;
                    if (result[j] == searchingNumber && count == 0)
                    {
                        searchingNumber = j;
                        count++;
                        j = 0;
                    }
                    else if(result[j] == searchingNumber && count == 1)
                    {
                        isTurnedTwice = false;
                        temp.Add(j);
                        count = 0;
                    }
                }
                isTurnedTwice = true;
            }


            return temp;
        }
    }
}
