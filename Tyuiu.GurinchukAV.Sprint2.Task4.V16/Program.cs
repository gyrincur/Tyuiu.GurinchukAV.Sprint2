using Tyuiu.GurinchukAV.Sprint2.Task4.V16.Lib;
namespace Tyuiu.GurinchukAV.Sprint2.Task4.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Гуринчук А.В. | ИБКб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет значение функции z в зависимости  *");
            Console.WriteLine("* от значений x и y с использованием тернарного оператора.                *");
            Console.WriteLine("* Результат округлить до трёх знаков после запятой.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x, y);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"РЕЗУЛЬТАТ: Z = {result}");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}