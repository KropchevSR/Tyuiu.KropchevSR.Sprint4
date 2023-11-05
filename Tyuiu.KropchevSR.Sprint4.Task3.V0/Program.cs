using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KropchevSR.Sprint4.Task3.V0.Lib;

namespace Tyuiu.KropchevSR.Sprint4.Task3.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт#4 | Задание 2 | Вариант 22 | Выполнил: Кропчев С. Р. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            int[,] mtrx = { { 5, 4, 9, 8, 5 },
                            { 4, 6, 6, 9, 9 },
                            { 9, 8, 4, 8, 8 },
                            { 6, 8, 6, 8, 9 },
                            { 9, 4, 6, 6, 7 } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{ mtrx[i, j]} \t");

                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");
            double res = ds.Calculate(mtrx);
            Console.WriteLine(" Наименьший элемент 4 столбца = " + res);
            Console.ReadKey();
        }
    }
}
