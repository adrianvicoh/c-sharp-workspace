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

        /*Invert number*/
        public static int InvertNumber(int numInput)
        {
            int numFinal = 0;
            int multiplier = 1;
            while (numInput > 0)
            {
                numFinal += numInput % 10 * multiplier;
                numInput /= 10;
                multiplier *= 10;
            }
            return numFinal;
        }
    }
}