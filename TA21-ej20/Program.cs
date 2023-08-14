using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Tamaño del primer array:");
            int tam1=int.Parse(Console.ReadLine());            
            int[] array1 = new int[tam1];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i]= rnd.Next(1,100);
            }
            int[] array2 = array1;
            array1 = new int[tam1];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 100);
            }
            TercerArray(array1, array2, tam1);
            MostrarArray(TercerArray(array1, array2, tam1));
            Console.ReadKey();  
        }

        private static void MostrarArray(int[] array3)
        {
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine("Posicion: "+i+" = "+array3[i]);
            }
        }

        private static int[] TercerArray(int[] array1, int[] array2, int tam1)
        {
            int[] array3 = new int[tam1];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] * array2[i];
            }
            return array3;
        }
    }
}
