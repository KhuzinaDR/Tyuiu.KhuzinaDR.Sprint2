using Tyuiu.KhuzinaDR.Sprint2.Task5.V8.Lib;
namespace Tyuiu.KhuzinaDR.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 11;
            int m = 4;
            var res = ds.FindDateOfPreviousDay(m, n);
            Assert.AreEqual(10 + "." + 04, res);
        }
    }
}