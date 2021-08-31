using System;
using Biblioteca;

namespace ejercicioI03ejemploUniversal
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear tres objetos Estudiante
            Estudiante e1 = new Estudiante("Benitez", "Sofia", "1000");
            Estudiante e2 = new Estudiante("Lopez", "Juan", "1001");
            Estudiante e3 = new Estudiante("Ramirez", "Lucia", "1002");


            //Cargar notas primer y segundo parcial
            e1.SetNotaPrimerParcial(7);
            e1.SetNotaSegundoParcial(8);

            e2.SetNotaPrimerParcial(6);
            e2.SetNotaSegundoParcial(9);

            e3.SetNotaPrimerParcial(2);
            e3.SetNotaSegundoParcial(2);

            //mostrar
            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());
        }
    }
}
