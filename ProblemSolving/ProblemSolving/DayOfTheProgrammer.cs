using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class DayOfTheProgrammer
    {
        public string DayOfTheProgrammerSol(int year)
        {
            string timeMachine;

            if(year <= 1917) //Julian Calendar
            {
                if(year % 4 == 0) //Julian Leap February 29
                {
                    timeMachine = "12.09." + Convert.ToString(year);
                }
                else //February 29
                {
                    timeMachine = "13.09." + Convert.ToString(year);
                }
            }
            else if(year > 1918) //Gregorian Calendar
            {
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) //Gregorian Leap February 29
                {
                    timeMachine = "12.09." + Convert.ToString(year);
                }
                else //February 29
                {
                    timeMachine = "13.09." + Convert.ToString(year);
                } 
            }
            else //1918
            {
                timeMachine = "26.09." + Convert.ToString(year);
            }

            return timeMachine;
        }
    }
}
