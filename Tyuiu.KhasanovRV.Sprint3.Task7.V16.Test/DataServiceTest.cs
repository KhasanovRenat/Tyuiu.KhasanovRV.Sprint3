using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint3.Task7.V16.Lib;

namespace Tyuiu.KhasanovRV.Sprint3.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5, stopValue = 5;
            double[] wait = new double[stopValue - startValue + 1];
            wait[0] = -36.41;
            wait[1] = -22.07;
            wait[2] = 5.68;
            wait[3] = 16.72;
            wait[4] = 8.35;
            wait[5] = -0.50;
            wait[6] = 9.63;
            wait[7] = 16.29;
            wait[8] = 5.01;
            wait[9] = -22.40;
            wait[10] = -36.30;

            var res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
