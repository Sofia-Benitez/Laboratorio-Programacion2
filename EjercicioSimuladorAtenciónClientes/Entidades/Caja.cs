using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    

    public class Caja
    {
        public delegate void DelegadoClienteAtendido(Caja caja, string cadena);
        private static Random random;
        private Queue<string> clientesALaEspera;
        string nombreCaja;
        private DelegadoClienteAtendido delegadoClienteAtendido;

        static Caja()
        {
          random = new Random();
        }

        public Caja(string nombreCaja, DelegadoClienteAtendido delegadoClienteAtendido)
        {
            this.nombreCaja = nombreCaja;
            this.delegadoClienteAtendido = delegadoClienteAtendido;
            clientesALaEspera = new Queue<string>();
        }

        public int CantidadDeClientesALaEspera
        {
            get
            {
                return clientesALaEspera.Count;
            }
        }
        public string NombreCaja { get => nombreCaja; }

        internal void AgregarCliente(string cliente)
        {
            this.clientesALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {
            return Task.Run(AtenderClientes);
            /*
            Task task = new Task(AtenderClientes);
            task.Start();
            return task;
            */
        }

        private void AtenderClientes()
        {
            do
            {
                if(clientesALaEspera.Any())// es como .Count > 0
                {
                    string cliente = clientesALaEspera.Dequeue();
                    if(delegadoClienteAtendido is not null)
                    {
                        delegadoClienteAtendido.Invoke(this, cliente);
                    }
                    Thread.Sleep(random.Next(1000, 5000));
                }


            } while (true);

        }
    }
}
