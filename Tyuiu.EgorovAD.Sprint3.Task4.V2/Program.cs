using Tyuiu.EgorovAD.Sprint3.Task4.V2.Lib;
namespace Tyuiu.EgorovAD.Sprint3.Task4.V2
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

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Вывод:"+ ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
