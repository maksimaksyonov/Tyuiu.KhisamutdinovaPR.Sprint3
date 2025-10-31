// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint3.Task6.V20.Test
// Description: Тест метода GetSumTheDivisors

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint3.Task6.V20.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int result = ds.GetSumTheDivisors(20, 32);

            // Все числа из диапазона [20,32] имеют менее 12 делителей, значит ожидаем 13
            Assert.AreEqual(13, result);
        }
    }
}
