using Tyuiu.DemchenkoAD.Sprint6.Task0.V5.Lib;
namespace Tyuiu.DemchenkoAD.Sprint6.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            double wait = -114.5;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);

        }
    }
}