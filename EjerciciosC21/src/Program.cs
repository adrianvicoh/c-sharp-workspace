using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosC21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            Console.WriteLine("");
            Console.WriteLine("===============");
            Console.WriteLine("Ejercicios C2.1");
            Console.WriteLine("===============");
            while (option != "exit")
            {
                switch (option)
                {
                    case "pow":
                        LoaderHandler.PowLoader();
                        option = "";
                        break;
                    case "div":
                        LoaderHandler.DivisionLoader();
                        break;
                    case "strc":
                        LoaderHandler.StringCompareLoader();
                        break;
                    case "datec":
                        LoaderHandler.DateCompareLoader();
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("------------------");
                        Console.WriteLine("Escribe la opción:");
                        Console.WriteLine("------------------");
                        Console.WriteLine("");
                        Console.WriteLine("pow\t-- potencia");
                        Console.WriteLine("div\t-- división");
                        Console.WriteLine("strc\t-- comparar Strings");
                        Console.WriteLine("datec\t-- comparar fechas");
                        Console.WriteLine("exit\t-- salir");
                        Console.WriteLine("");
                        Console.WriteLine("------------------");
                        Console.WriteLine("");
                        Console.Write("EJERCICIOS C2.1 > ");
                        option = Console.ReadLine();
                        break;
                }
            }
        }
    }
}