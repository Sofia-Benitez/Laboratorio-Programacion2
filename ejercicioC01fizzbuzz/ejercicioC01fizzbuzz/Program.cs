using System;
using ejercicioC01fizzbuzz;

namespace ejercicioC01fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero =3;
            Console.WriteLine(numero.ImplementarFizzBuzz());
            numero = 5;
            Console.WriteLine(numero.ImplementarFizzBuzz());
            numero = 15;
            Console.WriteLine(numero.ImplementarFizzBuzz());
        }
    }
}
