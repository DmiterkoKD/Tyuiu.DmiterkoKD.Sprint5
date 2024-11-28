using Tyuiu.DmiterkoKD.Sprint5.Task5.V2.Lib;
namespace Tyuiu.DmiterkoKD.Sprint5.Task5.V2.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string p = @"C:\Users\rugis\AppData\Local\Temp\InPutDataFileTask5V2.txt";
            FileInfo fileInfo = new FileInfo(p);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}