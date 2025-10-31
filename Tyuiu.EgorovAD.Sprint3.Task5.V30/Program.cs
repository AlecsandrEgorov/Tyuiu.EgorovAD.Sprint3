using Tyuiu.EgorovAD.Sprint3.Task5.V30.Lib;
namespace Tyuiu.EgorovAD.Sprint3.Task5.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;
            Console.WriteLine("x = " + x);
            Console.WriteLine("1 шаг:" + startValue1);
            Console.WriteLine("2 шаг:" + stopValue2);
            Console.WriteLine("3 шаг:" + startValue2);
            Console.WriteLine("4 шаг:" + stopValue2);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Вывод:" + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();
        }
    }
}
