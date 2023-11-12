using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KropchevSR.Sprint4.Task6.V17.Lib;

namespace Tyuiu.KropchevSR.Sprint4.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            DataService ds = new DataService();
            Console.Title = "Спринт#4 | Задание 6 | Вариант 17 | Выполнил: Кропчев С. Р. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("\nМассив");

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write($"{str[i]}  ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");
            int res = ds.Calculate(str);
            Console.WriteLine($"Сумма положительных элементов равна = {res}");
            Console.ReadKey();
        }
    }
}
