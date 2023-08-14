using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un valor numerico: ");
            int valor=int.Parse(Console.ReadLine());            
            Console.WriteLine(valor +" en binario es: "+ DecimalBinario(valor));
            Console.ReadKey();  
        }
        private static string DecimalBinario(int valor)
        {
            string binario= "";
            while (valor>0)
            {
                binario = valor % 2 + binario;
                valor=valor / 2;
            }            
            return binario;
        }
    }
}
