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
            bool validInt = true;
            String inputString;
            while (validInt)
            {
                Console.WriteLine("");
                Console.WriteLine("Introduce el primer número int de base");
                Console.WriteLine("");
                Console.Write("EJERCICIOS C2.1 > POTENCIA > ");
                inputString = Console.ReadLine();
                validInt = int.TryParse(inputString);
                if (validInt)
                {

                }
            }
            numBase = int.Parse(Console.ReadLine());
            Console.WriteLine("salir - exit");
            Console.WriteLine("");
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