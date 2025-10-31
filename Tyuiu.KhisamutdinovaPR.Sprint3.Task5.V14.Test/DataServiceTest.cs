// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint3.Task5.V14.Test
// Description: Тест метода GetSumSumSeries для варианта 14

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint3.Task5.V14.Lib;
using System;

namespace Tyuiu.AxyonovMA.Sprint3.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1, startValue2 = 1;
            int stopValue1 = 3, stopValue2 = 14;

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Проверим округлённое значение
            Assert.AreEqual(-20.765, Math.Round(result, 3));
        }
    }
}
