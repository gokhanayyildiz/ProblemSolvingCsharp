using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class DesignerPdfViewer
    {
        public int DesignerPdfViewerSol(List<int> h, string word)
        {
            int highestLetter = Int32.MinValue;
            int temp = 0, area;

            List<char> alphabet = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for(int i = 0; i < word.Length; i++)
            {
                for(int j =0;j<alphabet.Count;j++ )
                {
                    if(word[i] == alphabet[j])
                    {
                        temp = h[j];
                        break;
                    }
                }
                if (temp > highestLetter)
                    highestLetter = temp;
            }

            area = highestLetter * (word.Length);

            return area;
        }
    }
}
