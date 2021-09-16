using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class ViralAdvertising
    {
        public int ViralAdvertisingSol(int n)
        {
            decimal shared = 5;
            decimal liked;
            decimal cumulative = 0;

            for (int i = 1 ; i <= n ; i++)
            {
                liked = Math.Floor(shared / 2);
                cumulative += liked; 

                shared = liked * 3;
            }



            return Convert.ToInt32(cumulative);
        }
    }
}
