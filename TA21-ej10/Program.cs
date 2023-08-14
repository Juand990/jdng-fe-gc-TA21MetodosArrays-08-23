using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabla de multiplicar del...");
            int numero=int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero+" * "+i+" = "+numero*i);
            }
            Console.ReadKey();
        }
    }
}
