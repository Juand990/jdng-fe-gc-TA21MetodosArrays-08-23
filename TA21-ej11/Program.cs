using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array= {1,2,3,4,5,6,7,8,9,10 };
            int sumaArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumaArray = sumaArray + array[i];
            }
            Console.WriteLine("Suma del array: "+sumaArray);
            Console.ReadKey();
        }
    }
}
