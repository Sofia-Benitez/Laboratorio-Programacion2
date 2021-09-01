using System;
using Biblioteca;

namespace ejercicioI01sumador
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador(6);
            Sumador sumador2 = new Sumador(6);

            Console.WriteLine(sumador1 | sumador2);

            Console.WriteLine(sumador1.Sumar(4, 5) );
            Console.WriteLine(sumador2.Sumar("Hola", "mundo"));

            Console.WriteLine(sumador1.GetCantidadSumas());
            Console.WriteLine(sumador2.GetCantidadSumas());

            Console.WriteLine(sumador1+sumador2);

            Console.WriteLine(sumador1|sumador2);
        }
    }
}
