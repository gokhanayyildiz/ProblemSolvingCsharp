using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class BirthdayCakeCandles
    {
        public int SolBirthdayCakeCandles(List<int> candles)
        {
            int longestCandlesCount = 0;
            int longestCandle;
            //int temp;


            candles.Sort();
            candles.Reverse();

            longestCandle = candles[0];

            for (int i = 0; i < candles.Count; i++)
            {
                if (longestCandle == candles[i])
                    longestCandlesCount++;
            }



            //for (int i = 0; i < candles.Count - 1; i++)
            //{
            //    for (int j = i; j < candles.Count; j++)
            //    {
            //        if(candles[i] < candles[j])
            //        {
            //            temp = candles[i];
            //            candles[i] = candles[j];
            //            candles[j] = temp;
            //        }
            //    }
            //}


            //Array.Sort(Candles); Diziyi küçükten büyüğe sıralayacaktır.

            /*
            longestCandle = candles[0];
            longestCandlesCount++;

            for(int i = 1; i < candles.Count;i++)
            {
                if (candles[i] == longestCandle)
                    longestCandlesCount++;
            }
            */

            return longestCandlesCount;
        }
    }
}
