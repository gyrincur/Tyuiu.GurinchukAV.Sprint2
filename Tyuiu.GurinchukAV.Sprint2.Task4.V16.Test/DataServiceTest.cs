using Tyuiu.GurinchukAV.Sprint2.Task4.V16.Lib;
namespace Tyuiu.GurinchukAV.Sprint2.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double result1 = ds.Calculate(1, 3);   
            double result2 = ds.Calculate(5, 2);   

            Assert.AreEqual(1.111, result1);
            Assert.AreEqual(1.96, result2);
        }
    }
}