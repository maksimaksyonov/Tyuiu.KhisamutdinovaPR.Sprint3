// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint3.Task5.V14.Test
// Description: Тест на точный ответ варианта 14

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint3.Task5.V14.Lib;
using System;

namespace Tyuiu.AxyonovMA.Sprint3.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Should_Return_Expected_For_V14()
        {
            var ds = new DataService();

            double y = ds.GetSumSumSeries(
                x: 5,
                startValue1: 1, startValue2: 1,
                stopValue1: 3, stopValue2: 14);

            Assert.AreEqual(-31.275, Math.Round(y, 3));
        }
    }
}
