using Tyuiu.EgorovAD.Sprint3.Task2.V26.Lib;
namespace Tyuiu.EgorovAD.Sprint3.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int st = 1;
            int end = 17;
            double res = ds.GetMultiplySeries(value, st, end);
            double wait = 411589.537;
            Assert.AreEqual(wait, res);
        }
    }
}
