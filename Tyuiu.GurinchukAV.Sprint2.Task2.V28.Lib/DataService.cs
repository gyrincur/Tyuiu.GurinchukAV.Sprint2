using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GurinchukAV.Sprint2.Task2.V28.Lib
{
    public class DataService : ISprint2Task2V28
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 2 && x <= 6 && y >= 3 && y <= 5) ||      
               (x >= 10 && x <= 14 && y >= 3 && y <= 5) ||    
               (x >= 5 && x <= 9 && y >= 5 && y <= 11) ||     
               (x >= 2 && x <= 11 && y == 11) ||              
               (x == 11 && y >= 8 && y <= 11) ||              
               (x >= 5 && x <= 11 && y == 12))               
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
