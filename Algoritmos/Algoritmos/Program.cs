using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("División de 124 entre 8: " + DivisionControl.Division(124, 8));
            Console.WriteLine();
            Console.WriteLine("Media de 8, 14, 25: " + AverageControl.Average(new int[] { 8, 14, 25 }));
            Console.WriteLine();
            Console.WriteLine("Convertir a Camel Case 'hola que tal': " + CamelCaseControl.CamelCase("hola que tal"));
            DateTime date1 = new DateTime(2023, 4, 15);
            DateTime date2 = new DateTime(2024, 12, 4);
            Console.WriteLine();
            Console.WriteLine("Comparación entre fechas: " + date1 + " <---> " + date2);
            Console.WriteLine("Fecha más grande: " + DateControl.HighestDate(date1, date2));
            Console.WriteLine();
            Console.WriteLine("Comparar cadenas de caracteres:");
            Console.WriteLine("Cadena 1: Hola, adiós");
            Console.WriteLine("Cadena 2: Adiós, muy buenas");
            Console.WriteLine("Cadena más alta: " + StringControl.CompareStrings("Hola, adiós", "Adiós, muy buenas"));
            Console.WriteLine();
            Console.WriteLine("Es 'tenet' un palindromo: " + PalindromeControl.Palindrome("tenet"));
            Console.WriteLine("Es 'algo' un palindromo: " + PalindromeControl.Palindrome("algo"));
            Console.WriteLine("Es 'saddas' un palindromo: " + PalindromeControl.Palindrome("saddas"));
            Console.WriteLine("Es 'alguna cosa' un palindromo: " + PalindromeControl.Palindrome("alguna cosa"));
            Console.ReadKey();
        }
    }
}
