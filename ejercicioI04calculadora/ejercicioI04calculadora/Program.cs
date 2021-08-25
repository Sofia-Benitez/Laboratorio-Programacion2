using System;
using Biblioteca;

/*
 * Se le debe pedir al usuario que ingrese dos números 
 * y la operación que desea realizar (ingresando el caracter +, -, * o /).
 */
namespace ejercicioI04calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float primerNumeroIngresado;
            float segundoNumeroIngresado;
            char operador;
            float resultado;


            
            Console.WriteLine("Ingrese el primer operando: ");
            if(!(float.TryParse(Console.ReadLine(), out primerNumeroIngresado)))
            {
                Console.WriteLine("Error.Ingrese el primer operando: ");
                float.TryParse(Console.ReadLine(), out primerNumeroIngresado);
            }

            Console.WriteLine("Ingrese el segundo operando: ");
            if(!(float.TryParse(Console.ReadLine(), out segundoNumeroIngresado)))
            {
                Console.WriteLine("Error.Ingrese el segundo operando: ");
                float.TryParse(Console.ReadLine(), out segundoNumeroIngresado);
            }

            Console.WriteLine("Ingrese la operacion que desea realizar ( +, -, * o /): ");
            operador = char.Parse(Console.ReadLine());

            resultado = Calculadora.Calcular(primerNumeroIngresado, segundoNumeroIngresado, operador);

            if(resultado!=float.NaN)
            {
                Console.WriteLine($"Resultado: {resultado}");
            }
            else
            {
                Console.WriteLine("No se pudo realizar la operacion");
            }
            
        }
    }
}
