using Tyuiu.EgorovAD.Sprint3.Task7.V22.Lib;
namespace Tyuiu.EgorovAD.Sprint3.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("1 шаг:" + startValue);
            Console.WriteLine("2 шаг:" + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] value;

            value = new double[len];

            value = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    F(x)  |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0;  i <= len; i++)
            {
                Console.WriteLine("|{0, 5:d}     |   {1, 5:f2}  |", startValue, value[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();

        }
    }
}
