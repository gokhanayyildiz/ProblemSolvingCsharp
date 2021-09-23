using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class ChocolateFeast
    {
        public int ChocolateFeastSol(int n, int c, int m)
        {
            int eatenChocolatte = 0;
            int tempChocolate;
            int wrapper = 0;

            eatenChocolatte = n / c;
            wrapper = eatenChocolatte;

            //if(wrapper < m)
            //{
            //    return eatenChocolatte;
            //}
            //else
            //{
            //    while (wrapper != 1)
            //    {
            //        tempChocolate = wrapper / m;
            //        wrapper = tempChocolate + (wrapper % m);

            //        eatenChocolatte += tempChocolate;
            //    }

            //    return eatenChocolatte;
            //}


            while (wrapper >= m)
            {
                tempChocolate = wrapper / m;
                wrapper = tempChocolate + (wrapper % m);

                eatenChocolatte += tempChocolate;
            }

            return eatenChocolatte;
        }
    }
}
