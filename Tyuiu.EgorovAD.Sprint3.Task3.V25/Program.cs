using Tyuiu.EgorovAD.Sprint3.Task3.V25.Lib;
namespace Tyuiu.EgorovAD.Sprint3.Task3.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = " kjhgfuu gujut dtuu";
            char chr = 'u';
            Console.WriteLine("Исходная строка:" + value);
            Console.WriteLine("Исходный символ:" + chr);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Колво символов " + ds.GetMinCharCount(value, chr));
            Console.ReadKey();  
        }
    }
}
