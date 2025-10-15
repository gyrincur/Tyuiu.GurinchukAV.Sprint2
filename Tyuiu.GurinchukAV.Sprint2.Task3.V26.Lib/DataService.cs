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
                y = x + Math.Pow((x + 1) / Math.Cos(Math.Pow(x, 2)), x);
            }
            else if (x == 0)
            {
                y = 3 * 3 - Math.Sin(Math.Pow(x, 2));
            }
            else if (x > -30 && x < 0)
            {
                y = Math.Pow(Math.Sin(Math.Pow(x, 3)) / (x + 5), x);
            }
            else 
            {
                y = x + 7 * x - (1.0 / x);
            }

            return Math.Round(y, 3);
        }
    }
}