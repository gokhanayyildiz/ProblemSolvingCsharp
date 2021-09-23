using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class HallowenSale
    {
        public int HallowenSaleSol(int p, int d, int m, int s)
        {
            int sumOfPay = 0;

            sumOfPay += p;
            int i = 1;
 
            while(sumOfPay < s)
            {
                if(p > m)
                {
                    p -= d;
                    if(p < m)
                    {
                        sumOfPay += m;
                        i++;
                    }
                    else
                    {
                        sumOfPay += p;
                        i++;
                    }

                    
                }
                else
                {
                    sumOfPay += m;
                    i++; 
                }
            }
 
            if(sumOfPay > s)
                return i - 1; 
            else
                return i;
             
        }
    }
}
