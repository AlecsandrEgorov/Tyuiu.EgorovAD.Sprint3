using Tyuiu.EgorovAD.Sprint3.Task0.V16.Lib;
namespace Tyuiu.EgorovAD.Sprint3.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int value = 2;
            int st = 1;
            int end = 6;
            double res = ds.GetMultiplySeries(value, st, end);
            double wait = 262144;
            Assert.AreEqual(wait, res);
        }
    }
}
