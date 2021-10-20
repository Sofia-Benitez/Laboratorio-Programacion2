using System;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(ConsoleColor colorTinta, float tinta)
        {
            this.colorTinta = colorTinta;
            this.tinta = tinta;
        }

        public ConsoleColor Color
        {
            get
            {
                return colorTinta;
            }
            set
            {
                colorTinta = value;
            }
        }
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                tinta = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            if (tinta >= texto.Length * 0.1)
            {
                tinta -= texto.Length * 0.1F;

                return new EscrituraWrapper(((IAcciones)this).Color, texto);
            }
            return null;
        }

        public bool Recargar(int unidades)
        {
            tinta += unidades;
            return true;
        }

        public override string ToString()
        {
            return $"Boligrafo color: {colorTinta}. Cantidad de tinta: {tinta}";
        }
    }
}
