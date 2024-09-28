using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosC21
{
    public class NumberControl
    {
        static public int PowerOperation(int numBase, int numPow)
        {
            int result = numBase;
            for (int i = 1; i < numPow; i++)
            {
                result *= numBase;
            }
            return result;
        }

        /** Function Division
         * Return division between two numbers
         * input int dividend
         * input int divisor
         * return int result
         */
        public static int Division(int dividend, int divisor)
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
