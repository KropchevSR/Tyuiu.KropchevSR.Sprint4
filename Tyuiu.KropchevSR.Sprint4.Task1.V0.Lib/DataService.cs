using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KropchevSR.Sprint4.Task1.V0.Lib
{
    public class DataService : ISprint4Task1V19
    {
        public int Calculate(int[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    res += array[i];
                }
            }
            return res;
        }
    }
}
