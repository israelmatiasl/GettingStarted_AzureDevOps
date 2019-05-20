using GettingStarted.Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GettingStarted.Test
{
    [TestClass]
    public class InitializeTest
    {
        [TestMethod]
        public void SumaDeNumeros()
        {
            var resultado = 3 + 2;
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void RestaDeNumeros()
        {
            var resultado = 3 - 2;
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void MultiplicacionDeNumeros()
        {
            var resultado = 3 * 2;
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void DivisionDeNumeros()
        {
            var resultado = 10 / 2;
            Assert.AreEqual(5, resultado);
        }
    }
}
