using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int acaba = 0;
            Console.WriteLine("Tamaño array: ");
            int tam=int.Parse(Console.ReadLine());
            int[] array = new int[tam];
            for (int i = 0; i < array.Length; i++)
            {
                array[i]= rnd.Next(1,300+1);
            }            
            bool correcto = false;
            while (!correcto)
            {
                Console.WriteLine("Mostrar numeros que acaban en..");
                acaba = int.Parse(Console.ReadLine());
                if (acaba >= 0 && acaba <= 9)
                {
                    correcto = true;
                }
            }
            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%10==acaba)
                {
                    list.Add(array[i]);
                }
            }
            //-------------------------
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Posicion " + i + " = " + array[i]);
            }
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Numeros que acaban en "+acaba+" posicion "+i+" = "+list[i]);
            }
            Console.ReadKey();
        }
    }
}
