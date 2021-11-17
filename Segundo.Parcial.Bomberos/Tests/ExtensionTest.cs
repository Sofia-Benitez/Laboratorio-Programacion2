using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace Tests
{
    [TestClass]
    public class ExtensionTest
    {
        [TestMethod]
        public void CalcularDiferencia_DeberiaRetornarDiferenciaEnSegundos()
        {
            DateTime inicio = new DateTime(2021, 12, 15, 08, 08, 08);
            DateTime fin = new DateTime(2021, 12, 15, 08, 08, 10);

            int diferenciaEsperada = 2;

            double retorno = inicio.CalcularDiferencia(fin);

            Assert.AreEqual(diferenciaEsperada, retorno);
        }
    }
}
