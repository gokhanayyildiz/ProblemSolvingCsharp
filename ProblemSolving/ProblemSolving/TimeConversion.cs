using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class TimeConversion
    {
        public string TimeConversionSol(string s)
        {
            char[] arr = new char[s.Length - 2];
            int first;
            int second;

            if (s[8] == 'A')
            {
                if (s[0] == '1' && s[1] == '2')
                {
                    arr[0] = '0';
                    arr[1] = '0';
                    for (int i = 2; i < s.Length - 2; i++)
                    {
                        arr[i] = s[i];
                    }
                }
                else
                {
                    for (int i = 0; i < s.Length - 2; i++)
                    {
                        arr[i] = s[i];
                    }
                }
            }
            else
            {
                if (s[0] == '1' && s[1] == '2')
                {
                    for (int i = 0; i < s.Length - 2; i++)
                    {
                        arr[i] = s[i];
                    }
                }
                else
                {
                    first = 1 + Convert.ToInt32(s[0]);
                    second = 2 + Convert.ToInt32(s[1]);
                    arr[0] = Convert.ToChar(first);
                    arr[1] = Convert.ToChar(second);
                    for (int i = 2; i < s.Length - 2; i++)
                    {
                        arr[i] = s[i];
                    }
                }
            }

            string charStr = new string(arr);
            return charStr;

        }
    }
}
