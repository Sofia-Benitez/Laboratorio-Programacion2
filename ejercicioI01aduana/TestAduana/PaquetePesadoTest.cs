using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestAduana
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            // Arrange
            const decimal costoEnvio = 100;
            const decimal valorEsperado = 160;

            PaquetePesado paquetePesado = new PaquetePesado("", costoEnvio, "", "", 1);

            // Act
            decimal valorRetornado = paquetePesado.AplicarImpuestos();

            // Assert
            Assert.AreEqual(valorRetornado, valorEsperado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaIAfip()
        {
            // Arrange
            const decimal costoEnvio = 100;
            const decimal valorEsperado = 25;

            PaquetePesado paquetePesado = new PaquetePesado("", costoEnvio, "", "", 1);

            // Act
            decimal valorRetornado = ((IAfip)paquetePesado).Impuestos;

            // Assert
            Assert.AreEqual(valorRetornado, valorEsperado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            //Arrange
            decimal costoEnvio = 100;
            decimal valorEsperado = 35;

            PaquetePesado paquete = new PaquetePesado("", costoEnvio, "", "", 0);
            //act

            decimal valorRetornado = paquete.Impuestos;
            //Assert

            Assert.AreEqual(valorRetornado, valorEsperado);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            PaquetePesado paquete = new PaquetePesado("", 100, "", "", 2);

            bool retorno = paquete.TienePrioridad;

            Assert.IsFalse(retorno);
        }
    }
}
