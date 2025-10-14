using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GurinchukAV.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool isAboveParabola = y >= Math.Pow(x, 2);
            bool isBelowExponent = y <= Math.Exp(x);
            bool inXRange = x >= 0 && x <= 1;
            bool inYRange = y >= 0 && y <= Math.E;

            return isAboveParabola && isBelowExponent && inXRange && inYRange;
        }
    }
}