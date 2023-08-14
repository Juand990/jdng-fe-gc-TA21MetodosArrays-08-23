using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero: ");
            int valor=int.Parse(Console.ReadLine());            
            if (Esprimo(valor))
            {
                Console.WriteLine(valor + " es primo");
            }
            else
            {
                Console.WriteLine(valor + " NO es primo");
            }
            Console.ReadKey();
        }

        private static bool Esprimo(int valor)
        {
            int contador = 0;
            for (int i = 1; i <= valor; i++)
            {
                if (valor%i==0)
                {
                    contador++;
                }
            }
            if (contador==2)
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
