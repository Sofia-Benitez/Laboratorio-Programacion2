using System;

namespace Biblioteca
{
    public class Factorial
    {
        public static long CalcularFactorial(long numero)
        {
            int resultado=1;

            if(numero >= 0)
            {

                for (int i = 1; i <= numero; i++)
                {
                    resultado *= i;
                }

            }
            else if (numero == 0)
            {
                resultado = 1;
            }
           

            return resultado;
        }
    }
}
