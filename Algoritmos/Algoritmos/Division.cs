using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class Division
    {
        /** Function Division
         * Return division between two numbers
         * input int dividend
         * input int divisor
         * return int result
         */
        static int Division(int dividend, int divisor)
        {
            int result = 0;
            while (dividend >= divisor)
            {
                result = result + 1;
                dividend = dividend - divisor;
            }
            return result;
        }
    }
}
