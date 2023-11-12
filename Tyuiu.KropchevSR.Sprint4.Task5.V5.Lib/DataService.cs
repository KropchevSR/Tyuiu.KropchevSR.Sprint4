﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KropchevSR.Sprint4.Task5.V5.Lib
{
    public class DataService : ISprint4Task5V5
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns;j++)
                {
                    if (matrix[i, j] > 0) count += matrix[i, j];
                }
            }
            return count;
        }
    }
}
