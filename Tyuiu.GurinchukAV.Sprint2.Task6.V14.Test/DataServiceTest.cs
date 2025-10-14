using Tyuiu.GurinchukAV.Sprint2.Task6.V14.Lib;
namespace Tyuiu.GurinchukAV.Sprint2.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7, 1));
            Assert.AreEqual("Среда", ds.FindDayName(1, 3));
            Assert.AreEqual("Понедельник", ds.FindDayName(2, 7));
            Assert.AreEqual("Воскресенье", ds.FindDayName(10, 5));
        }
    }
}
