using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita1parte
{
    public class Local:Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo):this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, costo)
        {
            
        }

        public Local(float duracion, string nroDestino, string nroOrigen, float costo) 
            : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"El costo de la llamada es: {this.CostoLlamada}");
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
