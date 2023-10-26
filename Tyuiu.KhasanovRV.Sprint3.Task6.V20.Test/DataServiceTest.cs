using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint3.Task6.V20.Lib;

namespace Tyuiu.KhasanovRV.Sprint3.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 20, stopValue = 32;

            var sp = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 41;

            Assert.AreEqual(wait, sp);
        }
    }
}
