using Tyuiu.EgorovAD.Sprint3.Task6.V8.Lib;
namespace Tyuiu.EgorovAD.Sprint3.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 18;
            int stopValue = 28;
            double res = ds.GetSumTheDivisors(startValue, stopValue);
            double wait = 320;
            Assert.AreEqual(res, wait);
        }
    }
}
