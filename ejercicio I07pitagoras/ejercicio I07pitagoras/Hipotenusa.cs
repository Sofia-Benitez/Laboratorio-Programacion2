using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_I07pitagoras
{
    class Hipotenusa
    {

        public static float AplicarPitagoras(float bas, float altura)
        {
            float hipotenusa;
            hipotenusa = (float) Math.Sqrt(Math.Pow(bas,2) + Math.Pow(altura,2));

            return hipotenusa;
        }
    }
}
