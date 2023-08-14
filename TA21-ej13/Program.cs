using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tamaño del array: ");
            int tamaño=int.Parse(Console.ReadLine());
            int[] array = new int[tamaño];
            Random rnd= new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1,10+1);
                Console.WriteLine("Posicion "+i+" = " + array[i]);
            }
            Console.ReadKey();
        }
    }
}
