using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.SymbolStore;
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
         * input string to convert
         * return string with conversion
         */
        static String CamelCase(string inputString)
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

        /** Function HighestDate
         * Return the highest date
         * input date1
         * input date2
         * return date
         */
        static DateTime HighestDate(DateTime date1, DateTime date2)
        {
            DateTime highest = new DateTime();
            if (date1.Year == date2.Year)
            {
                if (date1.Month == date2.Month)
                {
                    if (date1.Day >= date2.Day)
                    {
                        highest = date1;
                    }
                    else
                    {
                        highest = date2;
                    }
                }
                else if (date1.Month > date2.Month)
                {
                    highest = date1;
                }
            }
            else if (date1.Year > date2.Year)
            {
                highest = date1;
            }
            else
            {
                highest = date2;
            }
            return highest;
        }

        /** Function CompareStrings
         * Return te highest alfabetical string
         * input string1
         * input string2
         * return string
         */
        static String CompareStrings(String string1, String string2)
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

        static void Main(string[] args)
        {
            Console.WriteLine("División de 124 entre 8: " + Division(124, 8));
            Console.WriteLine("Media de 8, 14, 25: " + Average(new int[] { 8, 14, 25 }));
            Console.WriteLine("Convertir a Camel Case 'hola que tal': " + CamelCase("hola que tal"));
            DateTime date1 = new DateTime(2023, 4, 15);
            DateTime date2 = new DateTime(2024, 12, 4);
            Console.WriteLine();
            Console.WriteLine("Comparación entre fechas: " + date1 + " --- " + date2);
            Console.WriteLine("Fecha más grande: " + HighestDate(date1, date2));
            Console.WriteLine();
            Console.WriteLine("Comparar cadenas de caracteres:");
            Console.WriteLine("Cadena 1: Hola, adiós");
            Console.WriteLine("Cadena 1: Adiós, muy buenas");
            Console.WriteLine("Cadena más alta: " + CompareStrings("Hola, adiós", "Adiós, muy buenas"));
            Console.ReadKey();
        }
    }
}
