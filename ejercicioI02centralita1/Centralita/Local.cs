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

        
        public Local(Llamada llamada, float costo):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(float duracion, string nroDestino, string nroOrigen, float costo) 
            : this(new Llamada(duracion, nroDestino, nroOrigen), costo)
        {

        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public string Mostrar()
        {
            return $"{base.Mostrar()} Costo: ${this.CostoLlamada}";
        }

        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }
    }
}
