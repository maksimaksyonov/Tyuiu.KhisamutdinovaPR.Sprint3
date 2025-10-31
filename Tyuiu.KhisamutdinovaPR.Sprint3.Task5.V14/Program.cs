// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint3.Task5.V14
// Description: Вычисление вложенной суммы для варианта 14

using System;
using Tyuiu.AxyonovMA.Sprint3.Task5.V14.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3 | Вложенные циклы | Задание #5 | Вариант #14                  *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1, startValue2 = 1;
            int stopValue1 = 3, stopValue2 = 14;

            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine($"Результат вычисления: y = {result:F3}");
            Console.ReadKey();
        }
    }
}
