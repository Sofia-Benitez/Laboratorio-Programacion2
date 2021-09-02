using System;
using Veterinaria;

namespace ejercicioA02veterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Mascota m1 = new Mascota("Perry", "perro", new DateTime(2018,06,11));
            Mascota m2 = new Mascota("Felix", "gato",  new DateTime(2020,07,13));
            Mascota m3 = new Mascota("felix", "gato", new DateTime(2021,06,21));
            Mascota m4 = new Mascota("Buddy", "perro", new DateTime(2017, 03, 01));

            Cliente c1 = new Cliente("Benitez", "sofia", "1234567", "Av. varela 900");
            Cliente c2 = new Cliente("Alvarez", "Lucia", "1543265345", "Av.Rivadavia 1600");
            Cliente c3 = new Cliente("Ruiz", "Pablo", "45654345", "Av. Avellaneda 2987");

            c1.AgregarMascota(m1);
            c2.AgregarMascota(m2);
            c3.AgregarMascota(m3);
            c3.AgregarMascota(m4);

            m2.AgregarVacuna("antirrabica");
            m2.AgregarVacuna("Triple Felina");
            m4.AgregarVacuna("antirrabica");


            Console.WriteLine(c1.MostrarCliente());
            Console.WriteLine(c2.MostrarCliente());
            Console.WriteLine(c3.MostrarCliente());

        }
    }
}
