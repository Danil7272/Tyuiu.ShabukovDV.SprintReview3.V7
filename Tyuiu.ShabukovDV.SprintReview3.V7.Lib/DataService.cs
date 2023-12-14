using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabukovDV.SprintReview3.V7.Lib;

namespace Tyuiu.ShabukovDV.SprintReview3.V7.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == -2)
                {
                    y = 0;
                    valueArray[count] = y;
                    count++;
                }

                else
                {
                    y = Math.Round((Math.Cos(x) + (Math.Cos(x) / (x + 2)) - 3 * x), 2);
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
