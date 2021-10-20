using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAcciones
    {
        public ConsoleColor Color { get; set; }
        public float UnidadesDeEscritura { get; set; }

        EscrituraWrapper Escribir(string texto);

        bool Recargar(int unidades);
    }
}
