using Microsoft.VisualStudio.TestTools.UnitTesting;
using IO;

namespace TestProject1
{
    [TestClass]
    public class TestArchivosJSON
    {
        [TestMethod]
        public void ValidarRuta_DeberiaRetornarTrueSiElArchivoEsJson()
        {
            //arrange
            string ruta = "archivo.json";
            PuntoJson<string> archivoJson = new PuntoJson<string>();

            //act
            bool retorno = archivoJson.ValidarExtension(ruta);

            //assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarRuta_DeberiaLanzarArchivoInocrrectoExeptioneSiElArchivoNoEsJSON()
        {
            //arrange
            string ruta = "archivo.bin";
            PuntoJson<string> archivoJson = new PuntoJson<string>();

            //act
            bool retorno = archivoJson.ValidarExtension(ruta);

            //assert
            Assert.IsFalse(retorno);
        }
    }
}
