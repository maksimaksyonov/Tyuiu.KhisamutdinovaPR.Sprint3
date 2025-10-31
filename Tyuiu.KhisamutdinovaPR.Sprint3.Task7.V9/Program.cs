// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint3.Task7.V9
// Description: Таблица значений F(x) на [-5;5] (шаг 1)

using System;
using Tyuiu.AxyonovMA.Sprint3.Task7.V9.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3 | Табулирование функции | Задание #7 | Вариант #9             *");
            Console.WriteLine("***************************************************************************");

            int start = -5, stop = 5;

            var ds = new DataService();
            double[] y = ds.GetMassFunction(start, stop);

            Console.WriteLine("   x\tF(x)");
            for (int i = 0; i < y.Length; i++)
            {
                int x = start + i;
                Console.WriteLine($"{x,4}\t{y[i]:F2}");
            }

            Console.ReadKey();
        }
    }
}
