// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint3.Task5.V14
// Description: Вычисление суммы для варианта 14

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
            Console.WriteLine("* Спринт #3 | Вложенные циклы | Задание #5 | Варинт #14                  *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1, startValue2 = 1; // i=1..3, k=1..14 — для части с sin(x)
            int stopValue1 = 3, stopValue2 = 14;

            var ds = new DataService();
            double y = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine($"y = {y:F3}"); // ожидаемо: -31.275
            Console.ReadKey();
        }
    }
}
