using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosC21
{
    internal class Program
    {
        // Método void para inciar método de potencia
        static void PowLoader()
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
                            Console.WriteLine(numBase + " elevado a " + numPow + " es igual a " + NumberController.PowerOperation(numBase, numPow));
                            Console.WriteLine("");
                            inputString = "exit";
                        }
                        else if (inputString != "exit")
                        {
                            Console.WriteLine("Input o número no válido");
                        }
                    }
                }
                else if (inputString != "exit")
                {
                    Console.WriteLine("Input o número no válido");
                }
            }
        }
        static void Main(string[] args)
        {
            string option = "";
            Console.WriteLine("");
            Console.WriteLine("===============");
            Console.WriteLine("Ejercicios C2.1");
            Console.WriteLine("===============");
            Console.WriteLine("");
            while (option != "exit")
            {
                switch (option)
                {
                    case "potencia":
                        PowLoader();
                        option = "";
                        break;
                    default:
                        Console.WriteLine("------------------");
                        Console.WriteLine("Escribe la opción:");
                        Console.WriteLine("------------------");
                        Console.WriteLine("");
                        Console.WriteLine("1 - potencia");
                        Console.WriteLine("salir - exit");
                        Console.WriteLine("");
                        Console.Write("EJERCICIOS C2.1 > ");
                        option = Console.ReadLine();
                        break;
                }
            }
        }
    }
}