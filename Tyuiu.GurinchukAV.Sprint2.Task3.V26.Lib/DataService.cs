using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GurinchukAV.Sprint2.Task3.V26.Lib
{
    public class DataService : ISprint2Task3V26
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 0)
            {
                y = x + ((x + 1) / Math.Cos(Math.Pow(x, 2)));
            }
            else if (x == 0)
            {
                y = 15 + x;
            }
            else if (x > -30 && x < 0)
            {
                y = (3 * Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2))) / (x + 5);
            }
            else 
            {
                y = x + 7 * x - (1.0 / x);
            }

            return Math.Round(y, 3);
        }
    }
}