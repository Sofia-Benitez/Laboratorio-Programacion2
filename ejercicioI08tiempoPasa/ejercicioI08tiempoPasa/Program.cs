using System;

namespace ejercicioI08tiempoPasa
{
    class Program
    {
        static void Main(string[] args)
        {
            double horasPasadas;
            int dia;
            int mes;
            int anio;

            Console.WriteLine("Ingrese el dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año: ");
            anio = int.Parse(Console.ReadLine());


            horasPasadas = ContadorDias.CalcularDias(dia, mes, anio);

            Console.WriteLine(horasPasadas);
        }
    }
}
