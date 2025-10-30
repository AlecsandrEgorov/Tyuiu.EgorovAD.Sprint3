using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.EgorovAD.Sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item)
        {
            int currentCount = 0;
            int minCount = int.MaxValue;

            foreach (char c in value)
            {
                if (c == item)
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > 0)
                    {
                        if (currentCount < minCount)
                        {
                            minCount = currentCount;
                        }
                        currentCount = 0;
                    }
                }
            }


            if (currentCount > 0 && currentCount < minCount)
            {
                minCount = currentCount;
            }


            if (minCount == int.MaxValue)
            {
                minCount = 0;
            }
            return minCount;
        }
    }
}
