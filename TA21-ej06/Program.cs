using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un valor numerico positivo: ");
            int valor = int.Parse(Console.ReadLine());
            bool correcto = false;
            while (!correcto)
            {
                if (valor >= 0)
                {
                    Console.WriteLine(valor + " tiene " + ContarCifras(valor) + " cifras.");
                    correcto = true;
                }
                else
                {
                    Console.WriteLine("El numero tiene que ser positivo, introducelo de nuevo.");
                    valor = int.Parse(Console.ReadLine());
                }
            }
            Console.ReadKey();
        }
        private static int ContarCifras(int valor)
        {
            int cifras = 0;

            while (valor > 0)
            {
                valor = valor / 10;
                cifras++;
            }
            return cifras;
        }
    }
}
