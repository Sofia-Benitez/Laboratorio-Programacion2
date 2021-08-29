using System;


namespace ejercicioI05tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string tabla="";

            Console.WriteLine("Ingrese un numero: ");
            if(int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                tabla=Tablas.DevolverTabla(numeroIngresado);
            }
            else
            {
                Console.WriteLine("Error. El dato ingresado no es un numero");
            }
           

            Console.WriteLine(tabla);

        }
    }
}
