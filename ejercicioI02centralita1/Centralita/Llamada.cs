using System;
using System.Text;

namespace Centralita1parte
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

       
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        //propiedad abstracta solo lectura
        public abstract float CostoLlamada { get; }
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        /// <summary>
        /// ordena las llamadas por duracion de menor a mayor.
        /// </summary>
        /// <param name="ll1"></param>
        /// <param name="ll2"></param>
        /// <returns>si la duracion de la llamada 1 es mas larga que la llamada 2 devuelve 1, sino devuelve -1 </returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int orden = 0;
            if(llamada1.Duracion > llamada2.Duracion)
            {
                orden = 1;
            }
            else if(llamada1.Duracion < llamada2.Duracion)
            {
                orden = -1;
            }

            return orden;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Duración de la llamada: {this.Duracion}");
            sb.AppendLine($"Numero de origen: {this.NroOrigen}");
            sb.AppendLine($"Numero de destino: {this.NroDestino}");

            return sb.ToString();
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && (l1.NroDestino == l2.NroDestino) && (l1.NroOrigen == l2.NroOrigen);
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

    }
}
