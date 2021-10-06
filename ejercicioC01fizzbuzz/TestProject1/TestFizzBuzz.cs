using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicioC01fizzbuzz;

namespace TestProject1
{
    [TestClass]
    public class TestFizzBuzz
    {
        [TestMethod]
        public void ImplementarFizzBuzz_CuandoNumeroEsDivisiblePor3Y5_DeberiaRetornarFizzBuzz()
        {
            //Arrange
            int numero = 15;
            string expected = "FizzBuzz";

            //Act

            string actual = numero.ImplementarFizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ImplementarFizzBuzz_CuandoNumeroEsDivisiblePor3_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 9;
            string expected = "Fizz";

            //Act

            string actual = numero.ImplementarFizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ImplementarFizzBuzz_CuandoNumeroEsDivisiblePor5_DeberiaRetornarBuzz()
        {
            //Arrange
            int numero = 10;
            string expected = "Buzz";

            //Act

            string actual = numero.ImplementarFizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ImplementarFizzBuzz_CuandoNumeroNoEsDivisiblePor5Y3_DeberiaRetornarVacio()
        {
            //Arrange
            int numero = 4;
            string expected = "";

            //Act

            string actual = numero.ImplementarFizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
