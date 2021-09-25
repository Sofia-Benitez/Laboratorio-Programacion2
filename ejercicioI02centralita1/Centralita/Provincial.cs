using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita1parte
{
    public class Provincial:Llamada
    {
        protected Franja franjaHoraria;
        public enum Franja
        {
            Franja_1, 
            Franja_2,
            Franja_3
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada llamada)
            :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float costoLlamada;

            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                   costoLlamada = base.Duracion * 0.99F;
                    break;
                case Franja.Franja_2:
                    costoLlamada = base.Duracion * 1.25F;
                    break;
                case Franja.Franja_3:
                    costoLlamada = base.Duracion * 0.66F;
                    break;
                default:
                    costoLlamada = 0;
                    break;
            }

            return costoLlamada;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"El costo de la llamada es: {this.CostoLlamada}");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
