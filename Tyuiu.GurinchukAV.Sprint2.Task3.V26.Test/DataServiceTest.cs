using Tyuiu.GurinchukAV.Sprint2.Task3.V26.Lib;

namespace Tyuiu.GurinchukAV.Sprint2.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_WhenXGreaterThanZero_ReturnsExpected()
        {
            DataService ds = new DataService();
            double x = 2;
            double expected = Math.Round(2 + Math.Pow((2 + 1) / Math.Cos(Math.Pow(2, 2)), 2), 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }
     }
}