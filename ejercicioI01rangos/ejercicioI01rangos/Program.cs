using System;
using Biblioteca;

namespace ejercicioI01rangos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int acumulador=0;
            int rangoMaximo = 100;
            int rangoMinimo = -100;
            int maximo=int.MinValue;
            int minimo=int.MaxValue;
            bool flag = true;
            int contadorNumeros = 0;
            int promedio;

            for(int i=0; i<10; i++)
            {
                Console.WriteLine("{0} - Ingrese un numero: ", i);
                valor = int.Parse(Console.ReadLine());


                if(Validador.Validar(valor, rangoMinimo, rangoMaximo))
                {
                   
                    if(contadorNumeros>0)
                    { 
                        flag = false;
                    }

                    if(flag || valor > maximo)
                    {
                        maximo = valor;
                    }
                    else if (flag || valor < minimo)
                    {
                        minimo = valor;
                    }
                    
                    acumulador += valor;
                    contadorNumeros++;

                }
                else
                {
                    Console.WriteLine("El numero no esta en el rango");
                    i--;
                }
                
            }

            promedio = acumulador / contadorNumeros;

            Console.WriteLine($"Numero maximo: {maximo}");
            Console.WriteLine($"Numero minimo: {minimo}");
            Console.WriteLine($"Promedio: {promedio}");

        }
    }
}
