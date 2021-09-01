using System;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidad)
        {
            cantidadSumas = cantidad;
        }

        public Sumador():this(0)
        {

        }

        public int GetCantidadSumas()
        {
            return cantidadSumas;
        }

        public  long Sumar(long valor1, long valor2)
        {
            this.cantidadSumas++;
            return valor1 + valor2;
        }

        public string Sumar(string valor1, string valor2)
        {
            this.cantidadSumas++;
            return valor1 + valor2;
        }

        public static explicit operator int(Sumador sumador1)
        {
            return sumador1.cantidadSumas;
        }

        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }

        public static bool operator | (Sumador sumador1, Sumador sumador2)
        {
            if(sumador1.cantidadSumas == sumador2.cantidadSumas)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
