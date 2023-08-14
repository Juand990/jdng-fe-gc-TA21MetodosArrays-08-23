using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce cantidad de EUROS a convertir: ");
            double euros = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce moneda a cambiar: dolar / yenes / libra");
            string moneda = Console.ReadLine();
            CambiarEuros(euros,moneda);
            Console.ReadKey();
        }

        private static void CambiarEuros(double euros, string moneda)
        {
            switch (moneda)
            {
                case "dolar":
                    Console.WriteLine(euros+ " euros a dolares= " + euros*1.28611+" dolares.");
                    break;

                case "yenes":
                    Console.WriteLine(euros + " euros a yenes= " + euros * 129.852+" yenes.");
                    break;

                case "libra":
                    Console.WriteLine(euros + " euros a libras= " + euros * 0.86+" libras.");
                    break;
                default:
                    Console.WriteLine("Moneda introducida incorrecta.");
                    break;
            }
        }
    }
}
