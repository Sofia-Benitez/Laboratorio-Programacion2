using System;

namespace ejercicioI08medioTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la altura deseada para el triangulo");
            int altura = int.Parse(Console.ReadLine());

            for(int i=1; i<=altura;i++)
            { 
                for (int j=1; j<=i; j++)
                {
                    if(j==1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("**");
                    }
                    
                }
                Console.WriteLine(" ");
            }
        }
    }
}
