using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class StringControl
    {
        /** Function CompareStrings
         * Return te highest alfabetical string
         * input string1
         * input string2
         * return string
         */
        public static String CompareStrings(String string1, String string2)
        {
            Boolean found = false;
            int counter = 0;
            String highest = string1;
            do
            {
                if (string1[counter] == string2[counter])
                {
                    counter++;
                }
                else if (string1[counter] > string2[counter])
                {
                    highest = string2;
                    found = true;
                }
                else
                {
                    found = true;
                }
            } while (counter <= string1.Length && counter <= string2.Length && !found);
            return highest;
        }
    }
}
