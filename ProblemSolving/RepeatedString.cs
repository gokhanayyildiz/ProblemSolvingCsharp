using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class RepeatedString
    {
        public long RepeatedStringSol(string s, long n)
        {
            long count = 0;

            List<char> str = new List<char>();

            while(str.Count < n)
            {
                for (int k = 0; k < s.Length; k++)
                {
                    str.Add(s[k]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (str[i] == 'a')
                    count++;
            }

            return count;

        }


        public void RepeatedStringSol2(string s, long n)
        {
            long lenghtOfString = s.Length;
            long numberOfa = 0;
            long division;
            long kalan;
            long result;

            for(int i=0; i < s.Length; i++ )
            {
                if (s[i] == 'a')
                    numberOfa++;
            }

            division = n / lenghtOfString;
            kalan = n % lenghtOfString;
            result = division * numberOfa;

            if(kalan != 0)
            {
                for(int i = 0; i < kalan; i++)
                {
                    if (s[i] == 'a')
                        result++;
                }
            }

            Console.WriteLine(lenghtOfString);
            Console.WriteLine(numberOfa);



            Console.WriteLine("a sayisi : " + result);
        }
    }
}
