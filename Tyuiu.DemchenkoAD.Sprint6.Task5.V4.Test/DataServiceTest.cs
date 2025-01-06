using System.Diagnostics;
using System.IO;
using Tyuiu.DemchenkoAD.Sprint6.Task5.V4.Lib;
namespace Tyuiu.DemchenkoAD.Sprint6.Task5.V4.Test
{

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                string[] paths = { @"C:\Users\12\source\repos\Tyuiu.DemchenkoAD.Sprint6\Tyuiu.DemchenkoAD.Sprint6.Task5.V4\bin\Debug\InPutDataFileTask5V4.txt" };
                string fullPath = Path.Combine(paths);

                FileInfo fileInfo = new FileInfo(fullPath);
                bool fileExists = fileInfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            }
        }
    }
}