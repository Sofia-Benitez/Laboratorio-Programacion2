using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestAduana
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostodeEnvioMasImpuestoAduana()
        {
            //Arrange
            decimal costoEnvio = 100;
            decimal valorEsperado = 135;

            PaqueteFragil paquete = new PaqueteFragil("", costoEnvio, "", "", 0);
            //Act
            decimal valorRetornado = paquete.AplicarImpuestos();
            //Assert
            Assert.AreEqual(valorEsperado, valorRetornado);

        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            //Arrange
            decimal costoEnvio = 100;
            decimal valorEsperado = 35;

            PaqueteFragil paquete = new PaqueteFragil("", costoEnvio, "", "", 0);
            //act

            decimal valorRetornado = paquete.Impuestos;
            //Assert

            Assert.AreEqual(valorRetornado, valorEsperado);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            PaqueteFragil paquete = new PaqueteFragil("", 100, "", "", 2);

            bool retorno = paquete.TienePrioridad;

            Assert.IsTrue(retorno);
        }
    }
}
