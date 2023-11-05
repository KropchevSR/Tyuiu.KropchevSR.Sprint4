using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KropchevSR.Sprint4.Task0.V0.Lib;

namespace Tyuiu.KropchevSR.Sprint4.Task0.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            DataService ds = new DataService();
            Console.Title = "Спринт#4 | Задание 0 | Вариант 9 | Выполнил: Кропчев С. Р. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine("Исходный массив :");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");
            double res = ds.GetSumEvenArrEl(numsArray);
            Console.WriteLine("Сумма четных элементов = " + res);
            Console.ReadKey();
        }
    }
}
