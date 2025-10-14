using Tyuiu.GurinchukAV.Sprint2.Task7.V5.Lib;
namespace Tyuiu.GurinchukAV.Sprint2.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0.5, 0.5));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.5, 0.1));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.5, 2.0));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(2.0, 1.0));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, 0));
        }
    }
}