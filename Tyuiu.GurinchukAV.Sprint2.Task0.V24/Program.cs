using Tyuiu.GurinchukAV.Sprint2.Task0.V24.Lib;

namespace Tyuiu.GurinchukAV.Sprint2.Task0.V24
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 135;
            int y = 755;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнил : Гуринчук А.В. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКСб-25-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,    *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
            Console.WriteLine("* (True, True, False, False, True, True), при x = 135, y = 755            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }
}