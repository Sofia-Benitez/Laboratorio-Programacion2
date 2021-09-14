using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PuestoAtencion
    {
        
        private Puesto puesto;
        private static int numeroActual;

        public enum Puesto
        {
            Caja1,
            Caja2
        }
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                PuestoAtencion.numeroActual++;
                return numeroActual;
            }

        }

        public bool Atender(Cliente cli)
        {
            if(cli is not null)
            {
                Thread.Sleep(1000);
                return true;
            }
            return false;
            
        }

        
    }

    
    
}
