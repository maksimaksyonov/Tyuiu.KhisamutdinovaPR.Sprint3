// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint3.Task7.V9.Lib
// Description: Табулирование функции F(x) на [-5;5] с шагом 1,
//              проверка деления на ноль; значения округлить до двух знаков.

using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AxyonovMA.Sprint3.Task7.V9.Lib
{
    // Реализуй нужный интерфейс из DLL (пример: ISprint3Task7V9)
    public class DataService : ISprint3Task7V9
    {
        // Шаблонный метод для этого задания
        // Возвращает массив значений F(x) на [startValue..stopValue] с шагом 1.
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int idx = 0;

            for (int x = startValue; x <= stopValue; x++, idx++)
            {
                double denom = Math.Cos(x) - 2.0 * x;

                double fx;
                if (Math.Abs(denom) < 1e-12) // проверка деления на ноль
                {
                    fx = 0.0;
                }
                else
                {
                    fx = (2.0 * x - 3.0) / denom + 5.0 * x - Math.Sin(x);
                }

                // Округление до двух знаков после запятой
                result[idx] = Math.Round(fx, 2);
            }

            return result;
        }
    }
}
