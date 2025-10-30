using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.EgorovAD.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double Eseries = 1;
            int i;
            for ( i = startValue; i <= stopValue; i++)
            {
                double term = (double)value / i;
                Eseries *= Math.Pow(term, 3);
            }
            return Math.Round(Eseries,3);
        }
        
    }
}
