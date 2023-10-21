using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhasanovRV.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0, min = 1000000;
            
            foreach (char c in value)
            {
                if (c == 'm')
                    count++;
                else
                {
                    if (count <= 1)
                        count = 0;
                    else
                    {
                        if (min > count)
                        {
                            min = count;
                        }
                        count = 0;
                    }

                }
            }
            return min;
        }
    }
}
