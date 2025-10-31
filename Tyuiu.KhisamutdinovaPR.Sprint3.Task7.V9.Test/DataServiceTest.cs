// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint3.Task7.V9.Test
// Description: Тест метода GetMassFunction

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint3.Task7.V9.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Should_Tabulate_Correctly_On_Range()
        {
            var ds = new DataService();
            var actual = ds.GetMassFunction(-5, 5);

            // Ожидаемый массив (радианы, шаг 1, округление до 2 знаков)
            double[] expected =
            {
                -27.22, -22.25, -16.66, -11.04, -6.13,
                -3.00,   4.84,   8.86,  14.43,  20.18, 25.24
            };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
