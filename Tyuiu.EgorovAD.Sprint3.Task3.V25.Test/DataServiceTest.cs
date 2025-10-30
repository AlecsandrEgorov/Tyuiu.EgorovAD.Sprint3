using Tyuiu.EgorovAD.Sprint3.Task3.V25.Lib;
namespace Tyuiu.EgorovAD.Sprint3.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "tughghuurghhu";
            char chr = 'u';

            double res = ds.GetMinCharCount(str, chr);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
