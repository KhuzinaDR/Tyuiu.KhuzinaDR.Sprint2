using Tyuiu.KhuzinaDR.Sprint2.Task4.V30.Lib;

namespace Tyuiu.KhuzinaDR.Sprint2.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;
            var res = ds.Calculate(x, y);
            double wait = 4;
            Assert.AreEqual(res, wait);
        }
    }
}