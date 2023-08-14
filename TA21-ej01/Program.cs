using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA21_ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que figura quieres obtener su Area??");
            Console.WriteLine("Circulo: 1");
            Console.WriteLine("Triangulo: 2");
            Console.WriteLine("Cuadrado: 3");
            int figura = int.Parse(Console.ReadLine());
            switch (figura)
            {
                case 1:
                    Console.WriteLine("Introduce valor para el radio: ");
                    double radio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area circulo: "+AreaCirculo(radio));
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Introduce valor para la base: ");
                    int baseTri = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce valor para la altura: ");
                    int alturaTri = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area triangulo: "+ AreaTriangulo(baseTri, alturaTri));                                        
                    Console.ReadKey();
                    break;

                case 3:                    
                    Console.WriteLine("Introduce valor para el lado: ");
                    int ladoCua = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area cuadrado: "+ AreaCuadrado(ladoCua));
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Valor introducido no valido.");
                    Console.ReadKey();
                    break;
            }
        }
        private static int AreaCuadrado(int ladoCua)
        {
            int area = (ladoCua * ladoCua);
            return area;
        }

        private static double AreaTriangulo(int baseTri, int alturaTri)
        {
            double area = (baseTri * alturaTri) / 2;
            return area;
        }

        private static double AreaCirculo(double radio)
        {
            double area = Math.Pow(radio, 2) * Math.PI;
            return area;
        }
    }
}
