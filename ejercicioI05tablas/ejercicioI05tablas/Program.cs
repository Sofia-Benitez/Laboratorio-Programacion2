using System;


namespace ejercicioI05tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string tabla;

            Console.WriteLine("Ingrese un numero: ");
            numeroIngresado = int.Parse(Console.ReadLine());
            tabla=Tablas.DevolverTabla(numeroIngresado);

            Console.WriteLine(tabla);

        }
    }
}
