using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhasanovRV.Sprint3.Task7.V16.Lib
{
    public class DataService : ISprint3Task7V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int i = 0;
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Cos(x) / (x - 0.4) + Math.Sin(x) * 8 * x + 2;
                res[i] = Math.Round(y, 2, MidpointRounding.AwayFromZero);
                i++;
            }
            return res;

        }
    }
}
