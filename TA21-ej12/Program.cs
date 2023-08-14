using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 21, 10, 13, 7, 18, 22, 3, 31, 8, 9 };
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma= suma + array[i];  
            }
            Console.WriteLine("Media del array: "+suma/array.Length);
            Console.ReadKey();
        }
    }
}
