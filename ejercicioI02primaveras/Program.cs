using System;
using Biblioteca;

namespace ejercicioI02
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Ricardo", new DateTime(1988, 08, 28), "38532435");
            Persona p2 = new Persona("Pollo", new DateTime(1989, 06, 09), "3155435");
            Persona p3 = new Persona("Chiqui", new DateTime(2009, 07, 01), "45532435");

            p1.SetNombre("Walter");
            Console.WriteLine(p1.Mostrar());
            Console.WriteLine(p1.EsMayorDeEdad());

            Console.WriteLine(p2.Mostrar());
            Console.WriteLine(p2.EsMayorDeEdad());

            Console.WriteLine(p3.Mostrar());
            Console.WriteLine(p3.EsMayorDeEdad());


        }
    }
}
