using Tyuiu.GurinchukAV.Sprint2.Task2.V28.Lib;
namespace Tyuiu.GurinchukAV.Sprint2.Task2.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Гуринчук А.В. | ИБКСб-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                           *");
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант #28                                                                  *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКСб-25-1                         *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая запрашивает X и Y                                *");
            Console.WriteLine("* и определяет, находится ли точка в заштрихованной                            *");
            Console.WriteLine("* области (см. рисунок по варианту 28).                                        *");
            Console.WriteLine("********************************************************************************");

            Console.Write("Введите X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine($"РЕЗУЛЬТАТ: Точка ({x}, {y}) " + (result ? "принадлежит" : "не принадлежит") + " заштрихованной области");
            Console.WriteLine("********************************************************************************");
        }
    }
}
