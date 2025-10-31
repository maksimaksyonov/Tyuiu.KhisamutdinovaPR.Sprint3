// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint3.Task5.V14.Lib
// Description: Вложенные циклы. Вариант 14. Двойная сумма по sin(x) и отдельная сумма по 2/k.

using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AxyonovMA.Sprint3.Task5.V14.Lib
{
    public class DataService : ISprint3Task5V14
    {
        // Требуемая сигнатура:
        // public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        //
        // Интерпретация для варианта 14:
        //   - по sin(x):     i = startValue1..stopValue1, k = startValue2..stopValue2  (то есть 1..3 и 1..14)
        //   - по 2/k:        i = startValue1..stopValue1, k = 1..2  (особенность варианта)
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0.0;

            // Двойная сумма по sin(x)
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum += Math.Sin(x); // x в радианах
                }
            }

            // Отдельная сумма по 2/k: для варианта 14 берём k = 1..2 и повторяем по i
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = 1; k <= 2; k++)
                {
                    sum += 2.0 / k;
                }
            }

            return sum;
        }
    }
}
