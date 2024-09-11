using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAlgoritmos
{
    internal class Program
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

        /** Function Average
         * Return the average of some numbers
         * input array with int numbers
         * return average
         */
        static float Average(int[] numbers)
        {
            int sum = 0;
            float average;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            average = sum / numbers.Length;
            return average;
        }

        /** Function CamelCase
         * Return an array with camel case
         * input array
         * return array with conversion
         */
        static String CamelCase(string inputString)
        {
            String newString = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                if (i == 0 || inputString[])
                {
                }
            }
            return "Hola";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("División de 124 entre 8: " + Division(124, 8));
            Console.WriteLine("Media de 8, 14, 25: " + Average(new int[] { 8, 14, 25 }));
            Console.ReadKey();
        }
    }
}
