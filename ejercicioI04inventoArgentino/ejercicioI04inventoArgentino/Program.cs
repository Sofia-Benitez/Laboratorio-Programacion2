using System;
using Biblioteca;

namespace ejercicioI04inventoArgentino
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Boligrafo biromeAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo biromeRoja = new Boligrafo(ConsoleColor.Red, 50);

            Console.ForegroundColor = biromeAzul.GetColor();
            Console.WriteLine($"Birome azul nivel de carga: {biromeAzul.GetTinta()}");
            Console.WriteLine(biromeAzul.Pintar(-10));
            Console.WriteLine($"Birome azul nivel de carga: {biromeAzul.GetTinta()}");
            biromeAzul.Recargar();
            Console.WriteLine($"Birome azul recargada: {biromeAzul.GetTinta()}");

            Console.ForegroundColor = biromeRoja.GetColor();
            Console.WriteLine($"Birome roja nivel de carga: {biromeRoja.GetTinta()}");
            Console.WriteLine(biromeRoja.Pintar(-45));
            Console.WriteLine($"Birome roja nivel de carga: {biromeRoja.GetTinta()}");
            Console.WriteLine(biromeRoja.Pintar(-1));
            biromeRoja.Recargar();
            Console.WriteLine($"Birome roja recargada: {biromeRoja.GetTinta()}");
            

            


        }
    }
}
