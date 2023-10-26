using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint3.Task4.V13.Lib;

namespace Tyuiu.KhasanovRV.Sprint3.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = -5, y = 5;
            var sp = ds.Calculate(x, y);
            double wait = 1.899;

            Assert.AreEqual(wait, sp);
        }
    }
}
