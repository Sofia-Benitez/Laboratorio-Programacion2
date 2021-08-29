using System;

namespace ejercicio_I07pitagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            float baseIngresada;
            float alturaIngresada;
            float hipotenusa=0;
            bool baseValida = false;
            bool alturaValida = false;

            Console.WriteLine("Pitágoras estaría orgulloso");
            Console.WriteLine("Ingresa la base del triangulo (en cm): ");
            baseValida = float.TryParse(Console.ReadLine(), out baseIngresada);

            Console.WriteLine("Ingresa la altura del triangulo (en cm): ");
            alturaValida = float.TryParse(Console.ReadLine(), out alturaIngresada);

            if(alturaValida && baseValida)
            {
                hipotenusa = Hipotenusa.AplicarPitagoras(baseIngresada, alturaIngresada);
            }
            else
            {
                Console.WriteLine("Error. Datos invalidos");
            }
            

            Console.WriteLine($"La hipotenusa del triangulo es {hipotenusa}");

        }
    }
}
