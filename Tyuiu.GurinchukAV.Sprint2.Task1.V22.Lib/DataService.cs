using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GurinchukAV.Sprint2.Task1.V22.Lib
{
        public class DataService : ISprint2Task1V22
        {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
                bool[] res = new bool[6];

                res[0] = a < b;    
                res[1] = b > c;    
                res[2] = a <= b;   
                res[3] = c == d;   
                res[4] = a > b;    
                res[5] = d >= b;   

                return res;
            }
        }
}