using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.EmelianovaKP.Sprint3.TaskReview.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        private double Func(int x)
        {
            if (Math.Cos(x) + x == 0)
            {
                return 0.00;
            }
            
            return Math.Round((2.0 * x - 3) / (Math.Cos(x) + x) + 5, 2);
        }

        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue - startValue + 1];

            int id = 0;

            for (int i = startValue; i <= stopValue; ++i)
            {
                result[id++] = Func(i);
            }



            return result;
        }
    }
}
