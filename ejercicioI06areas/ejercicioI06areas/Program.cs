using System;
using Biblioteca;

namespace ejercicioI06areas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("A. Calcular el Area de un cuadrado");
            Console.WriteLine("B. Calcular el Area de un triangulo");
            Console.WriteLine("C. Calcular el Area de un circulo");
            Console.WriteLine("Que operacion quiere realizar?: ");

            char opcion = char.Parse(Console.ReadLine());

            double resultado = double.NaN;

            switch (opcion)
            {
                case 'a':
                    Console.WriteLine("Ingrese la longitud del lado: ");
                    int longitud = int.Parse(Console.ReadLine());

                    resultado = CalculadoraDeArea.CalcularAreaCuadrado(longitud);

                    break;
                case 'b':
                    Console.WriteLine("Ingrese la base del triangulo: ");
                    int bas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triangulo: ");
                    int altura = int.Parse(Console.ReadLine());

                    resultado = CalculadoraDeArea.CalcularAreaTriangulo(bas, altura);

                    break;
                case 'c':
                    Console.WriteLine("Ingrese el radio del circulo: ");
                    int radio = int.Parse(Console.ReadLine());

                    resultado = CalculadoraDeArea.CalcularAreaCirculo(radio);

                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;

            }

            if(resultado!=double.NaN)
            {
                Console.WriteLine($"Resultado: {resultado}");
            }
            

        }
    }
}
