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
    }
}
