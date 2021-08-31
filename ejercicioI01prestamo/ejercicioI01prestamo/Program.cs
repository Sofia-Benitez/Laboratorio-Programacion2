using System;
using Biblioteca;

namespace ejercicioI01prestamo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Creo que necesito un prestamo");

            Cuenta cuenta1 = new Cuenta("Benitez, Sofia", 45000);

            Console.WriteLine(cuenta1.GetTitular());
            Console.WriteLine(cuenta1.GetCantidad());


            cuenta1.Retirar(3000);

            Console.WriteLine(cuenta1.Mostrar());

            cuenta1.Ingresar(1904);

            Console.WriteLine(cuenta1.Mostrar());

            Cuenta cuenta2 = new Cuenta("Benitez, Aldana", 5000);

            Console.WriteLine(cuenta2.Mostrar());

            Console.ReadKey();

        }
    }
}
