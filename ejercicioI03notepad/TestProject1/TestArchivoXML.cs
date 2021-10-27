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
            PuntoXML archivoJson = new PuntoXML();

            //act
            bool retorno = archivoJson.ValidarExtension(ruta);

            //assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void ValidarRuta_DeberiaRetornarFalseSiElArchivoEsPuntoBin()
        {
            //arrange
            string ruta = "archivo.bin";
            PuntoXML archivoJson = new PuntoXML();

            //act
            bool retorno = archivoJson.ValidarExtension(ruta);

            //assert
            Assert.IsFalse(retorno);
        }
    }
}