using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class FindDigits
    {
        public int SolFindDigits(int num)
        {
            int numberOfDivisorDigits = 0;
            int temp = num;
            int divisor;

            while(num > 0)
            {
                divisor = num % 10;

                if (divisor == 0)
                {
                    num = num / 10;
                    continue;
                }  
                
                if (temp % divisor == 0)
                    numberOfDivisorDigits++;

                num = num / 10;
            }

            return numberOfDivisorDigits;
        }
    }
}
