// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint3.Task6.V20.Test

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint3.Task6.V20.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Should_Return_41_For_20_32()
        {
            var ds = new DataService();
            int actual = ds.GetSumTheDivisors(20, 32);
            Assert.AreEqual(41, actual);
        }
    }
}
