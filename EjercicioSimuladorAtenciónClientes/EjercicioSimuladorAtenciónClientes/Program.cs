using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entidades;

namespace EjercicioSimuladorAtenciónClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja.DelegadoClienteAtendido clienteAtendidoDelegado = (caja, cliente) =>
            {
                string mensaje = $"{DateTime.Now:HH:MM:ss} - Hilo: {Task.CurrentId} - {caja.NombreCaja} - Atendiendo a: {cliente}." +
                $"Quedan {caja.CantidadDeClientesALaEspera} clientes en esta caja";
                Console.WriteLine(mensaje);
            };



            List<Caja> listaCajas = new List<Caja>()
            {
                new Caja("Caja 1", clienteAtendidoDelegado),
                new Caja("Caja 2", clienteAtendidoDelegado)
            };

            Negocio negocio = new Negocio(listaCajas);

            Console.WriteLine("Asignando cajas ... ");

            List<Task> hilos = negocio.ComenzarAccion(); //devuelve la lista de hils realizados

            Task.WaitAll(hilos.ToArray());


        }
    }
}
