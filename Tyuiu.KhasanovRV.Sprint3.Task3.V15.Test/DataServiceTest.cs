using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint3.Task3.V15.Lib;

namespace Tyuiu.KhasanovRV.Sprint3.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();
            string s = "lrmmse mg sermmmrt";
            int wait = 2;

            var res = ds.GetMinCharCount(s, 'm');
            Assert.AreEqual(wait, res);
        }
    }
}
