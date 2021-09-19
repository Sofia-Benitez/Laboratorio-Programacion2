using System;
using System.Text;

namespace Centralita1parte
{
    public class Llamada
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

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Duración de la llamada: {this.Duracion}");
            sb.AppendLine($"Numero de origen: {this.NroOrigen}");
            sb.AppendLine($"Numero de destino: {this.NroDestino}");

            return sb.ToString();
        }

       
    }
}
