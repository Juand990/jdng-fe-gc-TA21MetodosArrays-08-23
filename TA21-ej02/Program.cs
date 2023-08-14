using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Cantidad de numeros aleatorios: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor inicial del Random: ");
            int inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor final del Random: ");
            int final = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Random: " + MostrarRandom(rnd, inicial, final));
            }
            Console.ReadKey();
        }

        private static int MostrarRandom(Random rnd, int inicial, int final)
        {
            return rnd.Next(inicial, final + 1); //numero aleatorio entre inicial(incluido) y final(no incluido) / final+1 (incluido) 
        }
    }
}
