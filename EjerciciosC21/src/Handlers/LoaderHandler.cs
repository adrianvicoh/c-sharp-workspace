using EjerciciosC21.src.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosC21
{
    public class LoaderHandler
    {
        // Método void para inciar método de potencia
        public static void PowLoader()
        {
            int numBase, numPow;
            bool validInt = false;
            String inputString = "";
            while (inputString != "exit")
            {
                Console.WriteLine("");
                Console.WriteLine("Introduce el primer número int de base o escribe 'exit' para cancelar");
                Console.WriteLine("");
                Console.Write("EJERCICIOS C2.1 > POTENCIA > ");
                inputString = Console.ReadLine();
                validInt = int.TryParse(inputString, out numBase);
                if (validInt)
                {
                    while (inputString != "exit")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Introduce el segundo número int de potencia o escribe 'exit' para cancelar");
                        Console.WriteLine("");
                        Console.Write("EJERCICIOS C2.1 > POTENCIA > BASE " + numBase + " > ");
                        inputString = Console.ReadLine();
                        validInt = int.TryParse(inputString, out numPow);
                        if (validInt)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("///// " + numBase + " elevado a " + numPow + " es igual a " + NumberControl.PowerOperation(numBase, numPow));
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("");
                            inputString = "exit";
                        }
                        else if (inputString != "exit")
                        {
                            Console.WriteLine("Input o número no válido");
                            Console.WriteLine("");
                        }
                    }
                    inputString = "";
                }
                else if (inputString != "exit")
                {
                    Console.WriteLine("Input o número no válido");
                    Console.WriteLine("");
                }
            }
        }

        public static void DivisionLoader()
        {
            int numerator, divisor;
            bool validInt = false;
            String inputString = "";
            while (inputString != "exit")
            {
                Console.WriteLine("");
                Console.WriteLine("Introduce el primer número int a dividir o escribe 'exit' para cancelar");
                Console.WriteLine("");
                Console.Write("EJERCICIOS C2.1 > DIVISIÓN > ");
                inputString = Console.ReadLine();
                validInt = int.TryParse(inputString, out numerator);
                if (validInt)
                {
                    while (inputString != "exit")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Introduce el segundo número int divisor o escribe 'exit' para cancelar");
                        Console.WriteLine("");
                        Console.Write("EJERCICIOS C2.1 > DIVISIÓN > NUMERADOR " + numerator + " > ");
                        inputString = Console.ReadLine();
                        validInt = int.TryParse(inputString, out divisor);
                        if (validInt)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("///// " + numerator + " entre " + divisor + " es igual a " + NumberControl.Division(numerator, divisor));
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("");
                            inputString = "exit";
                        }
                        else if (inputString != "exit")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Input o número no válido");
                            Console.WriteLine("");
                        }
                    }
                    inputString = "";
                }
                else if (inputString != "exit")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Input o número no válido");
                    Console.WriteLine("");
                }
            }
        }

        public static void StringCompareLoader()
        {
            String string1 = "", string2 = "";
            while (string1 != "exit")
            {
                Console.WriteLine("");
                Console.WriteLine("Introduce el primer String o escribe 'exit' para cancelar");
                Console.WriteLine("");
                Console.Write("EJERCICIOS C2.1 > COMPARAR STRINGS > STRING 1 > ");
                string1 = Console.ReadLine();
                if (string1 != "exit")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Introduce el segundo String o escribe 'exit' para cancelar");
                    Console.WriteLine("");
                    Console.Write("EJERCICIOS C2.1 > COMPARAR STRINGS > STRING 2 > ");
                    string2 = Console.ReadLine();
                    if (string2 != "exit")
                    {
                        bool? compare = StringControl.CompareStrings(string1, string2);
                        Console.WriteLine("");
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("///// STRING 1 = '" + string1 + "'");
                        Console.WriteLine("///// STRING 2 = '" + string2 + "'\n");
                        Console.WriteLine("///// RESULTADO de comparación: " + compare);
                        if (compare == true)
                        {
                            Console.WriteLine("///// STRING 1 es el primero alfabéticamente");
                        }
                        else if (compare == false)
                        {
                            Console.WriteLine("///// STRING 2 es el primero alfabéticamente");
                        }
                        else
                        {
                            Console.WriteLine("///// STRING 1 y 2 son iguales");
                        }
                        Console.WriteLine("----------------------------------------------------");
                        string1 = "";
                        string2 = "";
                    }
                    else
                    {
                        string1 = "";
                        string2 = "";
                    }
                }
            }
        }

        public static void DateCompareLoader()
        {
            string date1, date2;
            Console.WriteLine("");
            Console.WriteLine("Introduce la primera fecha con formato dd/mm/aaaa");
            Console.WriteLine("");
            Console.Write("EJERCICIOS C2.1 > COMPARAR FECHAS > FECHA 1 > ");
            date1 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Introduce la segunda fecha con formato dd/mm/aaaa");
            Console.WriteLine("");
            Console.Write("EJERCICIOS C2.1 > COMPARAR FECHAS > FECHA 2 > ");
            date2 = Console.ReadLine();
            bool? compare = StringControl.CompareDate(date1, date2);
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("///// FECHA 1 = '" + date1 + "'");
            Console.WriteLine("///// FECHA 2 = '" + date2 + "'\n");
            Console.WriteLine("///// RESULTADO de comparación: " + compare);
            if (compare == true)
            {
                Console.WriteLine("///// FECHA 1 es posterior a FECHA 2");
            }
            else if (compare == false)
            {
                Console.WriteLine("///// FECHA 1 es anterior a FECHA 2");
            }
            else
            {
                Console.WriteLine("///// FECHAS 1 y 2 son iguales");
            }
            Console.WriteLine("----------------------------------------------------");
        }

        public static void InvertStrLoader()
        {
            string inputString = "";
            while (inputString != "exit")
            {
                Console.WriteLine("");
                Console.WriteLine("Introduce el String a invertir o escribe 'exit' para cancelar");
                Console.WriteLine("");
                Console.Write("EJERCICIOS C2.1 > INVERTIR STRING > ");
                inputString = Console.ReadLine();
                if (inputString != "exit")
                {
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("///// RESULTADO = '" + StringControl.InvertString(inputString) + "'");
                    Console.WriteLine("----------------------------------------------------");
                }
            }
        }

        public static void InvertNumLoader()
        {
            string inputString = "";
            int numInput = 0;
            bool validInt;
            while (inputString != "exit")
            {
                Console.WriteLine("");
                Console.WriteLine("Introduce el número entero a invertir o escribe 'exit' para cancelar");
                Console.WriteLine("");
                Console.Write("EJERCICIOS C2.1 > INVERTIR NÚMERO > ");
                inputString = Console.ReadLine();
                validInt = int.TryParse(inputString, out numInput);
                if (validInt)
                {
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("///// RESULTADO = '" + NumberControl.InvertNumber(numInput) + "'");
                    Console.WriteLine("----------------------------------------------------");
                }
                else if (inputString != "exit")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Input o número no válido");
                    Console.WriteLine("");
                }
            }
        }

        public static void PalindromeLoader()
        {
            string inputString = "";
            while (inputString != "exit")
            {
                Console.WriteLine("");
                Console.WriteLine("Introduce el el string a analizar o escribe 'exit' para cancelar");
                Console.WriteLine("");
                Console.Write("EJERCICIOS C2.1 > PALÍNDROMO > ");
                inputString = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("///// RESULTADO = " + StringControl.Palindrome(inputString));
                Console.WriteLine("----------------------------------------------------");
            }
        }
    }
}
