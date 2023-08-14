using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej18
{
    internal class Program
    {
        private static int rnd;

        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Tamaño del array:");
            int tamaño = int.Parse(Console.ReadLine());
            int[] array = new int[tamaño];
            int randInicio = 0;
            int randFinal = 9;
            RellenarArray(rnd,array, randInicio, randFinal);
            MostrarArray(array);
            Console.ReadKey();
        }

        private static void MostrarArray(int[] array)
        {
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma = suma + array[i];
                Console.WriteLine(i+" = " + array[i]);
            }
            Console.WriteLine("Suma del array: " + suma);
        }

        private static int[] RellenarArray(Random rnd, int[] array, int randInicio, int randFinal)
        {            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GenerarAleatorios(rnd,randInicio, randFinal);                   
            }
            return array;
        }

        private static int GenerarAleatorios(Random rnd, int randInicio, int randFinal)
        {            
            return rnd.Next(randInicio,randFinal);
        }
    }
}
