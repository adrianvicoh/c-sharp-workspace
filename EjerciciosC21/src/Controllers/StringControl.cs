using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosC21.src.Controllers
{
    public class StringControl
    {
        /** Function CompareStrings
         * Return te highest alfabetical string
         * input string1
         * input string2
         * return bool result
         */
        public static bool? CompareStrings(String string1, String string2)
        {
            bool? result = null;
            int counter = 0;
            do
            {
                if (string1[counter] == string2[counter])
                {
                    counter++;
                }
                else if (string1[counter] > string2[counter])
                {
                    result = false;
                }
                else
                {
                    result = true;
                }
            } while (counter < string1.Length && counter < string2.Length && result == null);
            return result;
        }

        /** Function DateCompare
         * Return boolan that inicates
         * if the second date is higher,
         * lower or equal
         * 
         * input string date1
         * input string date2
         * return bool result
         */
        public static bool? CompareDate(string date1, string date2)
        {
            bool? result = null;
            string[] dateString1 = date1.Split('/');
            string[] dateString2 = date2.Split('/');
            if (int.Parse(dateString1[2]) > int.Parse(dateString2[2]))
            {
                result = true;
            }
            else if (int.Parse(dateString1[2]) < int.Parse(dateString2[2]))
            {
                result = false;
            }
            else
            {
                if (int.Parse(dateString1[1]) > int.Parse(dateString2[1]))
                {
                    result = true;
                }
                else if (int.Parse(dateString1[1]) < int.Parse(dateString2[1]))
                {
                    result = false;
                }
                else
                {
                    if (int.Parse(dateString1[0]) > int.Parse(dateString2[0]))
                    {
                        result = true;
                    }
                    else if (int.Parse(dateString1[0]) < int.Parse(dateString2[0]))
                    {
                        result = false;
                    }
                }
            }
            return result;
        }
    }
}