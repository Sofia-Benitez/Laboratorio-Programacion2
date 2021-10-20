using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        public float tamanioMina;

        public Lapiz(float tamanioMina)
        {
            this.tamanioMina = tamanioMina;
        }

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return tamanioMina;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            if (tamanioMina >= texto.Length * 0.1)
            {
                tamanioMina -= texto.Length * 0.1F;

                return new EscrituraWrapper(((IAcciones)this).Color, texto);
            }
            return null;
        }

        public override string ToString()
        {
            return $"Lapiz color: {((IAcciones)this).Color}. Cantidad de mina: {tamanioMina}";
        }
    }
}
