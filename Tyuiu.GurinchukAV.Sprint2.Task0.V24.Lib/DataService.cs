using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GurinchukAV.Sprint2.Task0.V24.Lib
{
    public class DataService : ISprint2Task0V24
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 620 == y;
            res[1] = x + 1 != y;
            res[2] = x + 700 < y;
            res[3] = x + 1 > y;
            res[4] = x + 1 <= y;
            res[5] = x + 700 >= y;

            return res;

        }
    }
}