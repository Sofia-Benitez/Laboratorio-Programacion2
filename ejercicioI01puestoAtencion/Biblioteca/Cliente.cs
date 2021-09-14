using System;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }
        }

        

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return (c1.numero == c2.numero);
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
