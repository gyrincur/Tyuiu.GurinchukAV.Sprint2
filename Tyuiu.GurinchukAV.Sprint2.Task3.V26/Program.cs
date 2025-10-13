using Tyuiu.GurinchukAV.Sprint2.Task3.V26.Lib;

namespace Tyuiu.GurinchukAV.Sprint2.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Гуринчук А.В. | ИБКСб-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                          *");
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #26                                                                  *");
            Console.WriteLine("* Выполнила: Гуринчук Анастасия Витальевна | ИБКСб-25-1                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая вычисляет значение функции                       *");
            Console.WriteLine("* Y в зависимости от значения X.                                               *");
            Console.WriteLine("* Результат округлить до трёх знаков после запятой.                            *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine();

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine($"РЕЗУЛЬТАТ: Y = {result}");
            Console.WriteLine("********************************************************************************");
            Console.ReadKey();
        }
    }
}