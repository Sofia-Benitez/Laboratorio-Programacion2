using System;

namespace Biblioteca
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double area = Math.Pow(longitudLado, 2);

            return area;
        }

        public static double CalcularAreaTriangulo(double bas, double altura) 
        {
            double area = (bas * altura) / 2;
            return area;
        
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double area = Math.PI * Math.Pow(radio,2);

            return area;
        }
    }
}
