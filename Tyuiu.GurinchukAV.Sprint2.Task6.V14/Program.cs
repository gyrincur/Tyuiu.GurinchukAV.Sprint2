using Tyuiu.GurinchukAV.Sprint2.Task6.V14.Lib;
namespace Tyuiu.GurinchukAV.Sprint2.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Гуринчук А.В. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКСб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано целое число k (1 < k <= 365). Определить, каким днем недели        *");
            Console.WriteLine("* (понедельником, вторником, ... субботой или воскресеньем) является k-й  *");
            Console.WriteLine("* день не високосного года, в котором 1 января d-й день недели            *");
            Console.WriteLine("* (если 1 января — понедельник, то d = 1, если вторник — d = 2, ...,      *");
            Console.WriteLine("* если воскресенье — d = 7).                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер дня года k (1 < k <= 365): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите день недели 1 января d (1-7): ");
            int d = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            string result = ds.FindDayName(k, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"{k}-й день года будет: {result}");
            Console.ReadKey();
        }
    }
}