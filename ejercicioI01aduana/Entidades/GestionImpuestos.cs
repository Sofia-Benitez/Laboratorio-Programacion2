using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            impuestosAduana = new List<IAduana>();
            impuestosAfip = new List<IAfip>();
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            this.impuestosAduana.Add(paquete);

            if(paquete is IAfip)
            {
                IAfip paqueteAfip = (IAfip)paquete;
                this.impuestosAfip.Add(paqueteAfip);
            }
        }

        public void RegistrarImpuestos(IEnumerable<Paquete>paquetes)
        {
            foreach (Paquete item in paquetes)
            {
                RegistrarImpuestos(item);
             
            }
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal total = 0;
            foreach (IAduana item in impuestosAduana)
            {
                total += item.Impuestos;
            }
            return total;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal total = 0;
            foreach (IAfip item in impuestosAfip)
            {
                total += item.Impuestos;
            }
            return total;
        }
    }
}
