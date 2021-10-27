using Microsoft.VisualStudio.TestTools.UnitTesting;
using IO;

namespace TestProject1
{
    [TestClass]
    public class TestArchivoXML

    {
        [TestMethod]
        public void ValidarRuta_DeberiaRetornarTrueSiElArchivoEsPuntoXML()
        {
            //arrange
            string ruta = "archivo.xml";
            PuntoXML<string> archivo = new PuntoXML<string>();

            //act
            bool retorno = archivo.ValidarExtension(ruta);

            //assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarRuta_DeberiaRetornarFalseSiElArchivoEsPuntoBin()
        {
            //arrange
            string ruta = "archivo.bin";
            PuntoXML<string> archivo = new PuntoXML<string>();

            //act
            bool retorno = archivo.ValidarExtension(ruta);

            //assert
            Assert.IsFalse(retorno);
        }
    }
}