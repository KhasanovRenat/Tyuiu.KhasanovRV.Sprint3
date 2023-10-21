using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhasanovRV.Sprint3.Task2.V10.Lib
{
    public class DataService : ISprint3Task2V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;
            double t = Convert.ToDouble(value);
            double k = Convert.ToDouble(startValue);
            do
            {
                res = res * (Math.Pow(t, k) + 1 / (k + 1));
                k++;
            } while (k <= stopValue);
            return res;
            
        }
    }
}
