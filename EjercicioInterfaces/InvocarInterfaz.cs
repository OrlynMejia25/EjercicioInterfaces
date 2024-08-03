using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal class InvocarInterfaz : IOperaciones
    {
        public double CalcularAreaTrapecio()
        {
            Console.Write("Ingresa la base mayor del trapecio: ");
            double baseMayor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la base menor del trapecio: ");
            double baseMenor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la altura del trapecio: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            return 0.5 * (baseMayor + baseMenor) * altura;
        }

        public double CalcularPerimetroTriangulo()
        {
            Console.Write("Ingresa el lado 1 del triángulo: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa el lado 2 del triángulo: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa el lado 3 del triángulo: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());
            return lado1 + lado2 + lado3;
        }

        public double CalcularVolumenCilindro()
        {
            Console.Write("Ingresa el radio de la base del cilindro: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la altura del cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            return Math.PI * Math.Pow(radio, 2) * altura;
        }

        public double CalcularAreaRectangulo()
        {
            Console.Write("Ingresa el largo del rectángulo: ");
            double largo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa el ancho del rectángulo: ");
            double ancho = Convert.ToDouble(Console.ReadLine());
            return largo * ancho;
        }

        public double CalcularLongitudElipse()
        {
            Console.Write("Ingresa el semi-eje mayor de la elipse: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa el semi-eje menor de la elipse: ");
            double b = Convert.ToDouble(Console.ReadLine());
            return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
        }


        public void Imprimir()
        {
            Console.WriteLine("Resultados de las operaciones:");
            Console.WriteLine($"Área del Trapecio: {CalcularAreaTrapecio()}");
            Console.WriteLine($"Perímetro del Triangulo: {CalcularPerimetroTriangulo()}");
            Console.WriteLine($"Volumen del cilindro: {CalcularVolumenCilindro()}");
            Console.WriteLine($"Área del triángulo: {CalcularAreaRectangulo()}");
            Console.WriteLine($"Longitud de la circunferencia: {CalcularLongitudElipse()}");
        }

    }
}
