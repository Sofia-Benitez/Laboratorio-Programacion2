using System;
using Biblioteca;

namespace ejercicioA01factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            long numero;
            long resultado;
            Console.WriteLine("Ingrese un numero positivo: ");
            if(long.TryParse(Console.ReadLine(), out numero))
            {
                resultado = Factorial.CalcularFactorial(numero);
                Console.WriteLine($"El resultado del factorial de {numero} es {resultado}");
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un numero");
            }
        }
    }

    
}
