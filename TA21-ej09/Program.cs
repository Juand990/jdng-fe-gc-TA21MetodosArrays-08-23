using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("Introduce el valor, y pulsa ENTER:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());    
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Posicion "+i+" : "+ array[i]);
            }
            Console.ReadKey();
        }
    }
}
