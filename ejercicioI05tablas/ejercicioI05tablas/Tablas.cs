using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioI05tablas
{
    class Tablas
    {
        public static string DevolverTabla(int numero)
        {

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Tabla de multiplicar del numero {numero}");

            for (int i=0; i<=10; i++)
            {   
                stringBuilder.AppendLine($"{numero} x {i} = {numero * i}");
            }

            string tabla = stringBuilder.ToString();

            return tabla;
        }
    }
}
