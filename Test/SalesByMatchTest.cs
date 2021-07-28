using Desafios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class SalesByMatchTest
    {
        private SalesByMatch _salesByMatch;

        [TestInitialize]
        public void Setup()
        {
            _salesByMatch = new SalesByMatch();
        }

        [TestMethod]
        public void DeveriaVerificarSeNEstaEntre1e100()
        {
            // given
            var n = 107;
            List<int> ar = new List<int> { 1, 2, 1, 2, 1, 3, 2 };

            // when 
            var result = _salesByMatch.SockMerchant(n, ar);

            // then
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void DeveriaVerificarSeElementosDoArrayEstaEntre1e100()
        {
            // given
            var n = 8;
            List<int> ar = new List<int> { 1, 2, 1, 2, 1, 3, 2, 0 };

            // when 
            var result = _salesByMatch.SockMerchant(n, ar);

            // then
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void DeveriaMontarOsParesDoArray()
        {
            // given
            var n = 9;
            List<int> ar = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            var n2 = 10;
            List<int> ar2 = new List<int> { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };

            // when 
            var result = _salesByMatch.SockMerchant(n, ar);
            var result2 = _salesByMatch.SockMerchant(n2, ar2);

            // then
            Assert.AreEqual(3, result);
            Assert.AreEqual(4, result2);
        }
    }
}
