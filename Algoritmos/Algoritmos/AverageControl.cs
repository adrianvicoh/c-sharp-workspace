using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public static class AverageControl
    {
        /** Function Average
         * Return the average of some numbers
         * input array with int numbers
         * return average
         */
        public static float Average(int[] numbers)
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
    }
}
