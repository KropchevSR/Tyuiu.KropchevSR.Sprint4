using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KropchevSR.Sprint4.Task1.V0.Lib;

namespace Tyuiu.KropchevSR.Sprint4.Task1.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт#4 | Задание 1 | Вариант 19 | Выполнил: Кропчев С. Р. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");
            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();


            Console.WriteLine("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(numsArray[i] + "/t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");
            double res = ds.Calculate(numsArray);
            Console.WriteLine("Сумма четных элементов = " + res);
            Console.ReadKey();
        }
    }
}
