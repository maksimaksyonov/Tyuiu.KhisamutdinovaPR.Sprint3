// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint3.Task6.V20.Lib
// Description: Обработка целочисленной информации. Вариант 20.
//              Найти количество чисел на отрезке [20, 32], у которых количество делителей меньше 12.

using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AxyonovMA.Sprint3.Task6.V20.Lib
{
    public class DataService : ISprint3Task6V20
    {
        // Метод возвращает количество чисел, у которых число делителей < 12
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;

            for (int n = startValue; n <= stopValue; n++)
            {
                int divisors = 0;

                // считаем количество делителей
                for (int d = 1; d <= n; d++)
                {
                    if (n % d == 0)
                    {
                        divisors++;
                        if (divisors >= 12)
                            break; // можно прервать, если уже >=12
                    }
                }

                if (divisors < 12)
                    count++;
            }

            return count;
        }
    }
}
