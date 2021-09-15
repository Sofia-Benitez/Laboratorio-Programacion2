using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();//RETORNA EL PROXIMO CLIENTE DE LA COLA y lo saca
            }

            set
            {
                _ = this + value;//operador de descarte para que devuelva otro tipo de dato si lo agrega devuelve true 
            }                    //usa la sobrecarga del +
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente item in n.clientes)
            {
                if(c == item)
                {
                    return true;
                }
                
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n!=c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator  ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);//uso la pripiedad que devuelve el proximo cliente a atender. 
            }
            return false;
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }
    }
}
