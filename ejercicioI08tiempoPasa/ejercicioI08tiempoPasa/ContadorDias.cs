using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioI08tiempoPasa
{
    class ContadorDias
    {
        public static double CalcularDias(int dia, int mes, int anio)
        {
            DateTime dateIngresado = new DateTime(anio, mes, dia);
            DateTime dateTimeNow = DateTime.Now;

            System.TimeSpan diferencia = dateTimeNow - dateIngresado;

            double total;

            total = diferencia.TotalHours;

            return total;

        }
    }
}
