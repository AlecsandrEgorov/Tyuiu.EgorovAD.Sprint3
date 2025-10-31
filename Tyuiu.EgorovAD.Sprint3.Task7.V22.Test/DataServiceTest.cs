using Tyuiu.EgorovAD.Sprint3.Task7.V22.Lib;
namespace Tyuiu.EgorovAD.Sprint3.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] Value;
            Value = new double[len];
            Value[0] = 8.04;
            Value[1] = 6.68;
            Value[2] = 4.84;
            Value[3] = 1.76;
            Value[4] = 0.45;
            Value[5] = 0.5;
            Value[6] = -0.87;
            Value[7] = -2.42;
            Value[8] = -3.88;
            Value[9] = -6.83;
            Value[10] = -8.88;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(Value, res);
        }
    }
}
