using Tyuiu.GurinchukAV.Sprint2.Task7.V5.Lib;
namespace Tyuiu.GurinchukAV.Sprint2.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Гуринчук А.В. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКСб-25-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
            Console.WriteLine("* X,Y в заштрихованной области.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Точка ({x}; {y}) {(result ? "находится" : "не находится")} в заштрихованной области");
            Console.ReadKey();
        }
    }
}