using Tyuiu.EgorovAD.Sprint3.Task1.V26.Lib;
namespace Tyuiu.EgorovAD.Sprint3.Task1.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 8;


            Console.WriteLine("Переменная x = " + value);
            Console.WriteLine("от  " + startValue);
            Console.WriteLine("до  " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Ответ:" + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
