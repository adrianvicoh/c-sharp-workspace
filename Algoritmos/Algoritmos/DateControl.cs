using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class DateControl
    {
        /** Function HighestDate
         * Return the highest date
         * input date1
         * input date2
         * return date
         */
        public static DateTime HighestDate(DateTime date1, DateTime date2)
        {
            DateTime highest = new DateTime();
            if (date1.Year == date2.Year)
            {
                if (date1.Month == date2.Month)
                {
                    if (date1.Day >= date2.Day)
                    {
                        highest = date1;
                    }
                    else
                    {
                        highest = date2;
                    }
                }
                else if (date1.Month > date2.Month)
                {
                    highest = date1;
                }
            }
            else if (date1.Year > date2.Year)
            {
                highest = date1;
            }
            else
            {
                highest = date2;
            }
            return highest;
        }
    }
}
