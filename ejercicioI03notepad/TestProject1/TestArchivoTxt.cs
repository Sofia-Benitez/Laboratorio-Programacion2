using Microsoft.VisualStudio.TestTools.UnitTesting;
using IO;

namespace TestProject1
{
    [TestClass]
    public class TestArchivoTxt

    {
        [TestMethod]
        public void ValidarRuta_DeberiaRetornarTrueSiElArchivoEsPuntoTxt()
        {
            //arrange
            string ruta = "archivo.txt";
            PuntoTxt archivo = new PuntoTxt();

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
            PuntoTxt archivoJson = new PuntoTxt();

            //act
            bool retorno = archivoJson.ValidarExtension(ruta);

            //assert
            Assert.IsFalse(retorno);
        }
    }
}