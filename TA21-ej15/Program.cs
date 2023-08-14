using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arrayInvertida = new int[10];
            int pos = 0;
            for (int i = array.Length-1; i >= 0; i--)
            {
                arrayInvertida[pos] = array[i];
                pos++;
            }
            for (int i = 0; i < arrayInvertida.Length; i++)
            {
                Console.WriteLine("Pos: "+i+" = " + arrayInvertida[i]);
            }
            Console.ReadKey();
        }
    }
}
