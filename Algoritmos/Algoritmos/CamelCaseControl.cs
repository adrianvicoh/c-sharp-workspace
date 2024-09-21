using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public static class CamelCaseControl
    {
        /** Function CamelCase
         * Return an array with camel case
         * input string to convert
         * return string with conversion
         */
        public static String CamelCase(string inputString)
        {
            //String newString = "";
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] != ' ')
                {
                    if (i == 0 || inputString[i - 1] == ' ')
                    {
                        newString.Append(Char.ToUpper(inputString[i]));
                    }
                    else
                    {
                        newString.Append(Char.ToLower(inputString[i]));
                    }
                }
            }
            return newString.ToString();
        }
    }
}
