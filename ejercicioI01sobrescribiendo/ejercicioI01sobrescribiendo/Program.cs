using System;
using Biblioteca;

namespace ejercicioI01sobrescribiendo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            Sobrescrito sobrecarga = new Sobresobrescrito();

            Console.WriteLine(sobrecarga.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());

            Console.ReadKey();
        }
    }
}
