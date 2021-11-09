using System;

namespace Entidades
{
    public class Biblioteca
    {
        int codigoJuego;
        string genero;
        string juego;
        string usuario;

        public Biblioteca(int codigoJuego, string genero, string juego, string usuario)
        {
            this.codigoJuego = codigoJuego;
            this.genero = genero;
            this.juego = juego;
            this.usuario = usuario;
        }

        public int CodigoJuego { get => codigoJuego; }
        public string Genero { get => genero;  }
        public string Juego { get => juego;  }
        public string Usuario { get => usuario;  }
    }
}
