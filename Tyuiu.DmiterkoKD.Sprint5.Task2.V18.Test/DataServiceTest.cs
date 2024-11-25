using Tyuiu.DmiterkoKD.Sprint5.Task2.V18.Lib;
namespace Tyuiu.DmiterkoKD.Sprint5.Task2.V18.Test
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
            string p = @"C:\Users\rugis\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(p);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}