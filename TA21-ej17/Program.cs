using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            RellenarArray(array);
            MostrarArray(array);
            Console.ReadKey();
        }

        private static int[] RellenarArray(int[] array)
        {
            Console.WriteLine("Introduce numero para el array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        private static void MostrarArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Posicion "+i+" = " + array[i]);
            }
        }
    }
}
