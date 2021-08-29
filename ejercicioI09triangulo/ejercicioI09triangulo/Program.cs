using System;

namespace ejercicioI09triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.WriteLine("Ingrese la altura deseada para el triangulo: ");

            if(int.TryParse(Console.ReadLine(), out altura))
            {
                for(int i=1; i<=altura; i++)
                {
                    for(int j=1; j<=altura-i; j++)
                    {
                        Console.Write("");
                    }
                    for (int j = 1; j <= 2*i-1; j++)
                    {
                        Console.Write("*");
                    }


                    Console.Write("\n");
                }
            }


        }
    }
}
