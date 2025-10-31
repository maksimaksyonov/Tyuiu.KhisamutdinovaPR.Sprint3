// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint3.Task6.V20
// Description: Консольная программа для варианта 20.

using System;
using Tyuiu.AxyonovMA.Sprint3.Task6.V20.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task6.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3 | Обработка целочисленной информации | Задание #6 | Вариант #20 *");
            Console.WriteLine("***************************************************************************");

            int startValue = 20, stopValue = 32;

            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine($"Количество чисел из диапазона [{startValue}; {stopValue}]");
            Console.WriteLine("у которых количество делителей меньше 12:");
            Console.WriteLine($"Ответ: {result}");
            Console.ReadKey();
        }
    }
}
