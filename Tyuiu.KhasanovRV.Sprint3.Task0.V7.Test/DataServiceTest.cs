using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint3.Task0.V7.Lib;

namespace Tyuiu.KhasanovRV.Sprint3.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double a = 0.75;
            int k1 = 1, k2 = 20;

            var sum = ds.GetSumSeries(a, k1, k2);
            double z = -0.076;


            Assert.AreEqual(z, sum);
        }
    }
}
