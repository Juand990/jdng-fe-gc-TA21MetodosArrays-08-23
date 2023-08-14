using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 2, 1 };
            int inicio = 0;
            int final = array.Length-1;
            bool capicua = true;
            while (inicio < final)
            {
                if(array[inicio] != array[final])                
                {
                    capicua = false;
                }
                inicio++;
                final--;
            }
            if (capicua)
            {
                Console.WriteLine("La array es capicua.");
            }
            else
            {
                Console.WriteLine("La array NO es capicua.");
            }
            Console.ReadKey();
        }
    }
}
