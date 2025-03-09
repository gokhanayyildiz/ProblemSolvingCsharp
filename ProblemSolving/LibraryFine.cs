using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class LibraryFine
    {
        public int LibrariyFineSol(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int dayDif;
            int monthDif;
            int yearDif;

            int fine;
            int fineDay = 0;
            int fineMont = 0;

            //1 verilen günlerdir 2 ise verilmesi gereken gün
            //birbirinden çıkardığımızda 0 dan küçük bir değer geliyorsa zamanında verilmiş demek yıl --> ay --> gün

            dayDif = d1 - d2;
            monthDif = m1 - m2;
            yearDif = y1 - y2;


            if(yearDif <= 0)
            {
                if (yearDif < 0)
                    return 0;

                if (monthDif <= 0)
                {
                    if (monthDif < 0)
                        return 0;

                    if (dayDif > 0)
                    {
                        fineDay = 15 * dayDif;
                    }
                    else
                    {
                        fineDay = 0;
                    }
                }
                else
                {
                    fineMont = 500 * monthDif;
                }
            }
            else
            {
                return 10000;
            }


            fine = fineMont + fineDay;

            return fine;
        }
    }
}
