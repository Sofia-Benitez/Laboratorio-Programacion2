using System;

namespace Biblioteca
{
    public class Calculadora
    {
        public static float Calcular(float primerOperando, float segundoOperando, char operador)
        {
            float resultado;

            switch(operador)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;
                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;
                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;
                case '/':
                    if(Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else
                    {
                        resultado = float.NaN;
                    }
                   
                    break;
                default:
                    resultado = float.NaN;
                    break;
            }
           

            return resultado;
        }
            
        private static bool Validar(float segundoOperando)
        {
            bool resultado = true;

            if(segundoOperando == 0)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}
