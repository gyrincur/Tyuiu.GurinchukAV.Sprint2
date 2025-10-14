using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GurinchukAV.Sprint2.Task5.V4.Lib
{
    public class DataService : ISprint2Task5V4
    {
        public string FindCardSuit(int value)
        {
            string suit;
            switch (value)
            {
                case 1:
                    suit = "пики";
                    break;
                case 2:
                    suit = "трефы";
                    break;
                case 3:
                    suit = "бубны";
                    break;
                case 4:
                    suit = "червы";
                    break;
                default:
                    suit = "неверный номер масти";
                    break;
            }
            return suit;
        }
    }
}