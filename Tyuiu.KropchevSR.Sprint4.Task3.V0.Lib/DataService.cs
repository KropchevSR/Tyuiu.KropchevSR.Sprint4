using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KropchevSR.Sprint4.Task3.V0.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] array)
        {
            int res = 1000000;
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i < rows;i++)
            {
                for (int j = 0; j < columns;j++)
                {
                    if ((array[i,j] < res) & (j == 3))
                    {
                        res = array[i, j];
                    }
                }
            }
            if (res != 1000000)
                return res;
            else return 0;
        }
    }
}
