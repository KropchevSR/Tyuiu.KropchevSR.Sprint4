using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KropchevSR.Sprint4.Task7.V24.Lib;

namespace Tyuiu.KropchevSR.Sprint4.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 3;
            string str = "651827384219648";
            DataService ds = new DataService();
            Console.Title = "Спринт#4 | Задание 6 | Вариант 17 | Выполнил: Кропчев С. Р. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("\nСтрока");
            Console.Write($"{str}");
            Console.WriteLine("\nКоличество строк");
            Console.Write($"{n}");
            Console.WriteLine("\nКоличество столбцов");
            Console.Write($"{m}");
            Console.WriteLine();

            int[,] array = new int[n, m];
            int len = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[len]} \t ");
                    len++;
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");
            int res = ds.Calculate(n,m,str);
            Console.WriteLine($"Произведение четных элементов равна = {res}");
            Console.ReadKey();
        }
    }
}
