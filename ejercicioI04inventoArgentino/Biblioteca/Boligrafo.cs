using System;
using System.Text;

namespace Biblioteca
{
    public class Boligrafo
    {
        private ConsoleColor color;
        private short tinta;
        private static short cantidadTintaMaxima;

        static Boligrafo()
        {
            cantidadTintaMaxima = 100;
        }

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            
           
            if(tinta!=cantidadTintaMaxima)
            {
                short tintaActual;
                tintaActual = this.tinta += tinta;
                if (tintaActual >= 0 && tintaActual <= cantidadTintaMaxima)
                {
                    this.tinta = tintaActual;
                }
            }
            else
            {
                this.tinta = tinta;
            }
          
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public string Pintar(short gasto)
        {
            string dibujo;
            StringBuilder sb = new StringBuilder();

            if(this.tinta>= 0)
            {
                for (int i = 1; i <= -gasto; i++)
                { 
                    sb.Append("*");
                    
                }
                SetTinta(gasto);
            }
               
            dibujo = sb.ToString();

            return dibujo;
        }
    }
}
