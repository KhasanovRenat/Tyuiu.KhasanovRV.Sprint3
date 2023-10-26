using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint3.Task5.V21.Lib;

namespace Tyuiu.KhasanovRV.Sprint3.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int startValue1 = 1, startValue2 = 1, stopValue1 = 3, stopValue2 = 10, x = 2;

            var sp = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = -32.019;

            Assert.AreEqual(wait, sp);
        }
    }
}
