using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un valor numerico: ");
            int valor=int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial de "+valor+" es: "+CalcularFactorial(valor));
            Console.ReadKey();
        }

        private static int CalcularFactorial(int valor)
        {
            int factorial = 1;
            for (int i = 1; i <= valor; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
