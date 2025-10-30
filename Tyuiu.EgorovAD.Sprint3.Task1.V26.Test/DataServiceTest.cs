using Tyuiu.EgorovAD.Sprint3.Task1.V26.Lib;
namespace Tyuiu.EgorovAD.Sprint3.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataServiceTest ds = new DataServiceTest();
            int value = 5;
            int startValue = 1;
            int stopValue = 8;
            double res = ds.GetSumSeries(value,  startValue,  stopValue);
            double wait = 0;
            Assert.AreEqual(res, wait); 
        }
    }
}
