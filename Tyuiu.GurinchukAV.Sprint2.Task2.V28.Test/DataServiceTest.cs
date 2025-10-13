using Tyuiu.GurinchukAV.Sprint2.Task2.V28.Lib;
namespace Tyuiu.GurinchukAV.Sprint2.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.AreEqual(true, ds.CheckDotInShadedArea(3, 4));   
            Assert.AreEqual(true, ds.CheckDotInShadedArea(12, 4));  
            Assert.AreEqual(true, ds.CheckDotInShadedArea(7, 8));   
            Assert.AreEqual(false, ds.CheckDotInShadedArea(1, 1));  
            Assert.AreEqual(false, ds.CheckDotInShadedArea(15, 15)); 
        }
    }
}