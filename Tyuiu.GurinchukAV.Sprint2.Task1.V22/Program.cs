using Tyuiu.GurinchukAV.Sprint2.Task1.V22.Lib;

namespace Tyuiu.GurinchukAV.Sprint2.Task1.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Гуринчук А.В. | ИБКСб-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Логические операции                                                    *");
            Console.WriteLine("* Задание #1                                                                   *");
            Console.WriteLine("* Вариант #22                                                                  *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКСб-25-1                         *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу из операций сравнения и логических выражений,             *");
            Console.WriteLine("* которая вернет логическую последовательность (массив):                       *");
            Console.WriteLine("* (True, True, True, False, False, False),                                     *");
            Console.WriteLine("* при a = 324, b = 696, c = 254, d = 155.                                      *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
