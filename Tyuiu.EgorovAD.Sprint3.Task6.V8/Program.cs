using Tyuiu.EgorovAD.Sprint3.Task6.V8.Lib;
namespace Tyuiu.EgorovAD.Sprint3.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = 18;
            int stopValue = 28;
            Console.WriteLine("Начало отрезка:" + startValue);
            Console.WriteLine("КОНЕЦ отрезка:" + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Вывод:" + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
