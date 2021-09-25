using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita1parte
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaProvincial = 0;
            float gananciaLocal = 0;
            float gananciaRetornar = 0;

            foreach (Llamada item in this.Llamadas)
            {
                if(item is Local)
                {
                    gananciaLocal += ((Local)item).CostoLlamada;
                }
                else if(item is Provincial)
                {
                    gananciaProvincial += ((Provincial)item).CostoLlamada;
                }
            }

            switch(tipo)
            {
                case Llamada.TipoLlamada.Local:
                    gananciaRetornar = gananciaLocal;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    gananciaRetornar= gananciaProvincial;
                    break;
                default:
                    gananciaRetornar = gananciaLocal + gananciaProvincial;
                    break;
            }

            return gananciaRetornar;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razón social: {this.razonSocial}");
            sb.AppendLine($"Ganancia total: ${this.GananciasPorTotal}");
            sb.AppendLine($"Ganancia por llamadas provinciales: ${this.GananciasPorProvincial}");
            sb.AppendLine($"Ganancia por llamadas locales: ${this.GananciasPorLocal}");
            sb.AppendLine("---------------------  Listado de llamadas ----------------------");
            foreach (Llamada item in this.Llamadas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada (Llamada llamada)
        {
            this.listaDeLlamadas.Add(llamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool aux = false;

            foreach (var item in c.listaDeLlamadas)
            {
                if(llamada == item)
                {
                    aux = true;
                    break;
                }
            }

            return aux;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if(c!=llamada)
            {
                c.AgregarLlamada(llamada);
            }
            return c;
        }


    }
}
