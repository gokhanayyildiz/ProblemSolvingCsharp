using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class AppendAndDelete
    {
        public string AppendAndDeleteSol(string s, string t, int k)
        {
            int count = 0;
            int delete, add, move; 


            if(s.Length >= t.Length)
            {
                for (int i = 0; i < t.Length; i++)
                {
                    if (s[i] == t[i])
                        count++;
                    else
                        break;
                }
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == t[i])
                        count++;
                    else
                        break;
                }
            }

            
            delete = s.Length - count;
            add = t.Length - count;

  
            move = add + delete;

            if (move <= k)
                return "Yes";
            else
                return "No";
        }
    }
}
