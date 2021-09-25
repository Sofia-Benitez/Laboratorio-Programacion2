using System;
using Centralita1parte;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local(10.8F, "Gerli", "Bernal", 50);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local(6.5F, "Lanus", "Avellaneda", 50);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c += l1;
            c += l2;
            c += l3;
            c += l4;

            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());

            
        }
    }
}
