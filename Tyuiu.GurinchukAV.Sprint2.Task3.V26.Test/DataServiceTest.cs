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
            double result = ds.Calculate(2);
            Assert.AreEqual(2 + ((2 + 1) / Math.Cos(Math.Pow(2, 2))), result, 0.001);
        }

        [TestMethod]
        public void Calculate_WhenXEqualsZero_ReturnsExpected()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(0);
            Assert.AreEqual(15, result, 0.001);
        }

        [TestMethod]
        public void Calculate_WhenXBetweenMinus30AndZero_ReturnsExpected()
        {
            DataService ds = new DataService();
            double x = -5;
            double expected = (3 * Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2))) / (x + 5);
            double result = ds.Calculate(x);
            Assert.AreEqual(Math.Round(expected, 3), result, 0.001);
        }

        [TestMethod]
        public void Calculate_WhenXLessThanMinus30_ReturnsExpected()
        {
            DataService ds = new DataService();
            double x = -40;
            double expected = x + 7 * x - (1.0 / x);
            double result = ds.Calculate(x);
            Assert.AreEqual(Math.Round(expected, 3), result, 0.001);
        }
    }
}