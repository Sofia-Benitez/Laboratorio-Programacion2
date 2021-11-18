using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Entidades
{
    public class Negocio
    {
        private static RealNameGenerator realNameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;


        static Negocio()
        {
            realNameGenerator = new RealNameGenerator();
        }

        public Negocio(List<Caja> cajas)
        {
            this.cajas = cajas;
            clientes = new ConcurrentQueue<string>();
        }

        public List<Task> ComenzarAccion()
        {
            List<Task> hilos = new List<Task>();
            foreach (Caja item in this.cajas)
            {
                Task task = item.IniciarAtencion();
                hilos.Add(task);
            }

            Task taskSimulacionClientes = Task.Run(GenerarClientes);
            hilos.Add(taskSimulacionClientes);
           
            Task taskAsignacionCajas = Task.Run(AsignarCajas);
            hilos.Add(taskAsignacionCajas);

            return hilos;
        }

        private void GenerarClientes()
        {
            while(true)
            {
                string cliente = realNameGenerator.Generate();
                clientes.Enqueue(cliente);
                Thread.Sleep(1000);
            }
        }

        private void AsignarCajas()
        {
            while(true)
            {
                //cajas.Sort((c1, c2) => (c1.CantidadDeClientesALaEspera - c2.CantidadDeClientesALaEspera));
                Caja cajaMenosClientes = cajas.OrderBy(c => c.CantidadDeClientesALaEspera).First();//ordena por esa propiedad en asc
                 
                clientes.TryDequeue(out string cliente);
                if (!string.IsNullOrWhiteSpace(cliente))
                {
                    cajaMenosClientes.AgregarCliente(cliente);
                }
            }
            
        }

    }
}
