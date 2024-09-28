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
                            Console.WriteLine("///// " + numBase + " elevado a " + numPow + " es igual a " + NumberController.PowerOperation(numBase, numPow));
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
                            Console.WriteLine("///// " + numerator + " entre " + divisor + " es igual a " + NumberController.Division(numerator, divisor));
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
    }
}
