using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej08
{
    internal class Program
    {
        static void Main(string[] args)
        {
              
            int[] array = {1,2,3,4,5,6,7,8,9,10};

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Posicion "+i+" = "+array[i]);
            }
            Console.ReadKey();
        }
    }
}
