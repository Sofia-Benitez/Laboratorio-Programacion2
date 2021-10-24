using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestAduana
{
    [TestClass]
    public class GestionImpuestosTest
    {

        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            // Arrange
            const decimal valorEsperado = 105;

            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaqueteFragil("", 100M, "", "", 1));
            paquetes.Add(new PaquetePesado("", 200M, "", "", 1));

            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            gestionImpuestos.RegistrarImpuestos(paquetes);

            // Act
            decimal valorRetornado = gestionImpuestos.CalcularTotalImpuestosAduana();

            // Assert
            Assert.AreEqual(valorRetornado, valorEsperado);
        }

        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            // Arrange
            const decimal valorEsperado = 50;

            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaqueteFragil("", 100M, "", "", 1));
            paquetes.Add(new PaquetePesado("", 200M, "", "", 2));

            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            gestionImpuestos.RegistrarImpuestos(paquetes);

            // Act
            decimal valorRetornado = gestionImpuestos.CalcularTotalImpuestosAfip();

            // Assert
            Assert.AreEqual(valorRetornado, valorEsperado);
        }
    }
}
