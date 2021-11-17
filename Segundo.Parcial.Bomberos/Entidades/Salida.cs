using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Salida
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;

        public Salida()
        {
            this.fechaInicio = DateTime.Now;
        }

        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }

        public double TiempoTotal
        {
            get
            {
                return (fechaInicio - fechaFin).TotalMinutes;
            }
        }

        public void FinalizarSalida()
        {
            this.fechaFin = DateTime.Now;
        }
    }
}
