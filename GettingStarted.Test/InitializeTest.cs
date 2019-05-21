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
            var operaciones = new Initialize();
            var resultado = operaciones.Suma(3, 2);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void RestaDeNumeros()
        {
            var operaciones = new Initialize();
            var resultado = operaciones.Resta(3, 2);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void MultiplicacionDeNumeros()
        {
            var operaciones = new Initialize();
            var resultado = operaciones.Multiplica(3, 2);
            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void DivisionDeNumeros()
        {
            var operaciones = new Initialize();
            var resultado = operaciones.Divide(10, 2);
            Assert.AreEqual(5, resultado);
        }
    }
}
