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
            PuntoTxt<string> archivoJson = new PuntoTxt<string>();

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
            PuntoTxt<string> archivoJson = new PuntoTxt<string>();

            //act
            bool retorno = archivoJson.ValidarExtension(ruta);

            //assert
            Assert.IsFalse(retorno);
        }
    }
}