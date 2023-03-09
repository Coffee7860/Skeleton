using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStocks
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStocks stocks = new clsStocks();
            Assert.IsNotNull(stocks);
        }
    }
}
