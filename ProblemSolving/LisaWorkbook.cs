using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class LisaWorkbook
    {
        public int LisaWorkbookSol(int n, int k, List<int> arr)
        {
            int countSpecials = 0;
            int page = 1;
            int questionsInPage;

            for (int i = 0; i < arr.Count; i++)
            {
                questionsInPage = k;
                for(int j = 1; j <= arr[i]; j++)
                {
                    if(j <= questionsInPage)
                    {
                        if (page == j)
                            countSpecials++;
                    }
                    else
                    {
                        page++;
                        questionsInPage += k;

                        if (page == j)
                            countSpecials++;
                    }
                }
                page++;
            }
             
            return countSpecials;
        }
    }
}
