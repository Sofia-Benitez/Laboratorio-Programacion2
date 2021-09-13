using System;
using Biblioteca;

namespace ejercicioC01estadisticaDeportiva
{
    class Program
    {
        static void Main(string[] args)
        {

            Equipo equipo = new Equipo(2, "Richmond");
            Jugador j1 = new Jugador(31982345, "Roy", 5, 20);
            Jugador j2 = new Jugador(4865655, "Ted", 3, 5);
            Jugador j3 = new Jugador(31982345, "Roy", 7, 3);
            Jugador j4 = new Jugador(789, "Sam", 3, 5);

            if (equipo + j1)
                Console.WriteLine(j1.MostrarDatos());

            if (equipo + j2)
                Console.WriteLine(j2.MostrarDatos());

            if (equipo + j3)
                Console.WriteLine(j3.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO " + j3.MostrarDatos());

            if (equipo + j4)
                Console.WriteLine(j4.MostrarDatos());

            else
                Console.WriteLine("NO SE AGREGO " + j4.MostrarDatos());
        }
    }
}
