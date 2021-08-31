using System;
using Veterinaria;

namespace vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota[] mascotas = new Mascota[3];

            Mascota felix = new Mascota("Felix", new DateTime(1990, 01, 01), "gato");

            mascotas[0] = felix;
            mascotas[1] = new Mascota("Salem", new DateTime(1998, 09, 09), "gato");

            Console.WriteLine($"´{felix.GetNombre()} nacio el {felix.GetFechaNacimiento()} y es un {felix.GetEspecie()}");
        }
    }
}
