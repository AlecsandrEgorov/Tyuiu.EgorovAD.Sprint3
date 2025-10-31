using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.EgorovAD.Sprint3.Task6.V8.Lib
{
    public class DataService : ISprint3Task6V8
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            int sum2 = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d  = 1; d <= x; d++)
                {
                    if (x % d == 0) 
                    {
                        sum += d;
                        if ( sum >= 11)
                        {
                            sum2 += d;
                            sum = 0;
                        }
                    }
                }
            }
            return sum2;
        }
    }
}
