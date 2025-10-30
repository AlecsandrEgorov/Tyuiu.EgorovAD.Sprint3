using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.EgorovAD.Sprint3.Task2.V26.Lib
{
    public class DataService : ISprint3Task2V26
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double ser = 1;
            while (startValue <= stopValue)
            {
                ser = ser * ((Math.Pow(value, 3) * startValue) + 2);
                startValue++;
            }
            return Math.Round(ser, 3);
        }
    }
}
