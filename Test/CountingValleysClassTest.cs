using Desafios;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class CountingValleysClassTest
    {
        private CountingValleysClass _countingValleysClass;

        [TestInitialize]
        public void Setup()
        {
            _countingValleysClass = new CountingValleysClass();
        }


        [TestMethod]
        public void DeveriaVerificarSeNEstaEntre2e10Elevado6()
        {
            var steps = 1;
            var path = "UDDDUDUU";

            // when 
            var result = _countingValleysClass.CountingValleys(steps, path);

            // then
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void DeveriaVerificarSeElementosDoStringTemUD()
        {
            // given
            var steps = 12;
            var path = "DDUUDDUDUUWUD";

            // when 
            var result = _countingValleysClass.CountingValleys(steps, path);

            // then
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(12, "DDUUDDUDUUUD", 2)]
        [DataRow(8, "UDDDUDUU", 1)]
        public void DeveriaMontarOsParesDoArray(int steps, string path, int experado)
        {
            // when 
            var result = _countingValleysClass.CountingValleys(steps, path);
            
            // then
            Assert.AreEqual(experado, result);
        }

    }
}
