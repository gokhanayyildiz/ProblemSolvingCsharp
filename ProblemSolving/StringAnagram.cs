using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class StringAnagram
    {
        public List<int> SolStringAnagram(List<string> dictionary, List<string> query)
        {
            List<int> hasAnagram = new List<int>();
            int count = 0;
            int eleman = 0;
            
            

            for(int i = 0; i < query.Count; i++)
            {
                char[] que = new char[query[i].Length];
                que = Sirala(query[i]);

                for(int j = 0; j < dictionary.Count; j++)
                {
                    char[] dic = new char[dictionary[j].Length];
                    dic = Sirala(dictionary[j]);
                    
                    if (que.Length == dic.Length)
                    {
                        for(int m = 0; m < que.Length; m++)
                        {
                            if (que[m] == dic[m])
                                eleman++;
                        }

                    }

                    if (eleman == que.Length)
                        count++;

                    eleman = 0;
                }

                hasAnagram.Add(count);
                count = 0;
            }



            return hasAnagram;
        }

        public char[] Sirala(string kelime)
        {
            char[] dizi = new char[kelime.Length];

            for (int i = 0; i < kelime.Length; i++)
                dizi[i] = kelime[i];


            Array.Sort(dizi);

            return dizi;
        }
    }
}
