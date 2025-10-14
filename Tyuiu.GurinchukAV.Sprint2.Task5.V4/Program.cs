using Tyuiu.GurinchukAV.Sprint2.Task5.V4.Lib;
namespace Tyuiu.GurinchukAV.Sprint2.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Гуринчук А.В. | ИБКб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3,                 *");
            Console.WriteLine("* масти «червы» — 4. По заданному номеру масти m (1 <= m <= 4) определить *");
            Console.WriteLine("* название соответствующей масти.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер масти (1-4): ");
            int m = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            string result = ds.FindCardSuit(m);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Номер масти: {m} -> Название: {result}");
            Console.ReadKey();
        }
    }
}