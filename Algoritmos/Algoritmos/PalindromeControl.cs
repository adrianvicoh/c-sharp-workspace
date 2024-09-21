using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class PalindromeControl
    {
        /** Function Palindrome
         * Return true if the string is a plaindrome
         * input string
         * return boolean
         */
        public static Boolean Palindrome(String stringInput)
        {
            Boolean isPalindrome = true;
            int counter = 0;
            int inverse = stringInput.Length - 1;
            while (isPalindrome && counter != inverse && counter + 1 != inverse)
            {
                if (stringInput[counter] == stringInput[inverse])
                {
                    counter++;
                    inverse--;
                }
                else
                {
                    isPalindrome = false;
                }
            }
            return isPalindrome;
        }
    }
}