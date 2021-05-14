using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class BeautifulDaysAtTheMovies
    {
        public int SolBeautifulDaysAtTheMovies(int i, int j, int k)
        {
            int beautifulDays = 0;
            int difference;

            for (int counter = i; counter <= j; counter++)
            {
                difference = counter - Reverse(counter);

                if (difference % k == 0)
                    beautifulDays++;
            }


            return beautifulDays;
        }

        public int Reverse(int num)
        {
            int reverse = 0;

            while (num != 0)
            {
                reverse *= 10;
                reverse += num % 10;
                num = num / 10;
            }


            return reverse;

        }
    }
}
