using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class AngryProfessor
    {
        public string SolAngryProfessor(int k, List<int> a)
        {
            int arrivedOnTime = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] <= 0)
                    arrivedOnTime++;
            }

            if (arrivedOnTime >= k)
                return "NO";
            else
                return "YES";
        }
    }
}
