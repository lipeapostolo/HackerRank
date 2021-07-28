using Desafios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class ElectronicsShopTest
    {
        private ElectronicsShop _electronicsShop;

        [TestInitialize]
        public void Setup()
        {
            _electronicsShop = new ElectronicsShop();
        }

        [TestMethod]
        public void DeveriaretornarDiferenteDe1Negativo()
        {
            //given
            List<int> keyboards = new List<int> {3, 1 };
            List<int> drives = new List<int> { 5, 2, 8 };

            int b = 10;

            //when
            var result = _electronicsShop.getMoneySpent(keyboards, drives, b);

            //then
            Assert.AreEqual(58, result);
        }
    }
}
