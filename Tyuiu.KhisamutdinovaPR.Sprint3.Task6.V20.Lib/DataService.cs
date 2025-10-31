// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint3.Task6.V20.Lib
// Description: Суммарное количество делителей < 12 на отрезке [startValue..stopValue]

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AxyonovMA.Sprint3.Task6.V20.Lib
{
    public class DataService : ISprint3Task6V20
    {
        // Возвращает сумму количества делителей d<12 для всех n ∈ [startValue..stopValue]
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int total = 0;

            for (int n = startValue; n <= stopValue; n++)
            {
                int cnt = 0;
                // Перебираем только d < 12 (как требует условие)
                for (int d = 1; d < 12; d++)
                {
                    if (n % d == 0) cnt++;
                }
                total += cnt;
            }

            return total;
        }
    }
}
