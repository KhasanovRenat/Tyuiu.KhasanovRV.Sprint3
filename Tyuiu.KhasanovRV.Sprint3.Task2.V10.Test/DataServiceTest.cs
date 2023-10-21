using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint3.Task2.V10.Lib;

namespace Tyuiu.KhasanovRV.Sprint3.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1, stopValue = 13, value = 1;
            var res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 7.5;

            Assert.AreEqual(wait, res);
        }
    }
}
