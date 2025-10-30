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
            int st = 1;
            int end = 8;
            Console.WriteLine("Переменная x = " + value);
            Console.WriteLine("от  " + st);
            Console.WriteLine("до  " + end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Ответ:" + ds.GetSumSeries(value, st, end));
            Console.ReadKey();
        }
    }
}
