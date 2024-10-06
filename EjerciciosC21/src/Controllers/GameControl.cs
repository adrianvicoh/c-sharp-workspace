using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosC21.src.Controllers
{
    public class GameControl
    {
        public static void GuessGame()
        {
            Random rng = new Random();
            int number = rng.Next(1, 20);
            int counter = 1;
            Console.WriteLine("");
            Console.WriteLine("Adivina un número entre 1 y 20:");
            Console.WriteLine("");
            string input = Console.ReadLine();
            int inputNum = int.Parse(input);
            while (inputNum != number)
            {
                if (inputNum > number)
                {
                    Console.WriteLine("Menos");
                    input = Console.ReadLine();
                    inputNum = int.Parse(input);
                    counter++;
                }
                else {
                    Console.WriteLine("Más");
                    input = Console.ReadLine();
                    inputNum = int.Parse(input);
                    counter++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("///// ¡CORRECTO! ");
            Console.WriteLine("///// Número de intentos: " + counter);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");
        }
    }
}
