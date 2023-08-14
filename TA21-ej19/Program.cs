using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej19
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Random rnd = new Random();  
            Console.WriteLine("Tamaño del array: ");
            int tamaño = int.Parse(Console.ReadLine());
            int[] array = new int[tamaño];
            Console.WriteLine("Rango INFERIOR de los numeros primos:");
            int inPrimo = int.Parse(Console.ReadLine());
            Console.WriteLine("Rango SUPERIOR de los numeros primos:");
            int fiPrimo = int.Parse(Console.ReadLine());
            Console.WriteLine(esPrimo(17)); 
            RellenarArray(array, rnd, inPrimo, fiPrimo);
            MostrarArray(array);
            Console.ReadKey();
        }
        private static void MostrarArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Posicion "+i +" = "+ array[i]);
            }
        }
        private static void RellenarArray(int[]array, Random rnd, int inPrimo, int fiPrimo)
        {            
            for (int i = 0; i < array.Length; )
            {
                int primo = rnd.Next(inPrimo, fiPrimo);
                if (esPrimo(primo))
                {
                    array[i] = primo;
                    i++;
                }
            }
        }
        private static bool esPrimo(int primo)
        {
            int cont = 0;
            for (int i = 1; i <= primo; i++)
            {
                if (primo % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
