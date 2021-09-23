using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class TaumAndBday
    {
        public long TaumAndBdaySol(int bm, int wm, int bcm, int wcm, int zm)
        {
            long b = bm;
            long w = wm;
            long bc = bcm;
            long wc = wcm;
            long z = zm;


            //************/ DOĞRU ÇÖZÜM_1 /************//
            //long result = 0;

            //if ((wc + z) < bc)
            //{
            //    result = b * (wc + z) + w * wc;
            //}
            //else if ((bc + z) < wc)
            //{
            //    result = w * (bc + z) + b * bc;
            //}
            //else
            //{
            //    result = b * bc + w * wc;
            //}


            //return result;


            //************/ DOĞRU ÇÖZÜM_2 /************//

            List<long> result = new List<long>();

            result.Add(b * (wc + z) + w * wc);
            result.Add(w * (bc + z) + b * bc);
            result.Add(b * bc + w * wc);

            result.Sort();

            return result[0];




            //************/ DOĞRU ÇÖZÜM_3 /************//
            //long result = b * Math.Min((wc + z), bc) + w * Math.Min((bc + z), wc);

            //return result;
        }
    }
}
