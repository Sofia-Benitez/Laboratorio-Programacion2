using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juego
    {
        private int codigoJuego;
        private int codigoUsuario;
        private string genero;
        private string nombre;
        private double precio;

        public Juego(int codigoUsuario, string genero, string nombre, double precio)
        {
            this.codigoUsuario = codigoUsuario;
            this.genero = genero;
            this.nombre = nombre;
            this.precio = precio;
        }

        public Juego(int codigoUsuario, string genero, string nombre, double precio, int codigoJuego):this(codigoUsuario, genero, nombre, precio)
        {
            this.codigoJuego = codigoJuego;
        }

        public int CodigoJuego { get => codigoJuego;  }
        public int CodigoUsuario { get => codigoUsuario; }
        public string Genero { get => genero;  }
        public string Nombre { get => nombre;  }
        public double Precio { get => precio;  }
    }
}
