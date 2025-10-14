using Tyuiu.GurinchukAV.Sprint2.Task5.V4.Lib;
namespace Tyuiu.GurinchukAV.Sprint2.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardSuit()
        {
            DataService ds = new DataService();

            string result1 = ds.FindCardSuit(1);
            string result2 = ds.FindCardSuit(2);
            string result3 = ds.FindCardSuit(3);
            string result4 = ds.FindCardSuit(4);
            string result5 = ds.FindCardSuit(0);
            string result6 = ds.FindCardSuit(5);

            Assert.AreEqual("пики", result1);
            Assert.AreEqual("трефы", result2);
            Assert.AreEqual("бубны", result3);
            Assert.AreEqual("червы", result4);
            Assert.AreEqual("неверный номер масти", result5);
            Assert.AreEqual("неверный номер масти", result6);
        }
    }
}