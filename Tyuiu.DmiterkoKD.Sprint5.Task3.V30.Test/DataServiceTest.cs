using Tyuiu.DmiterkoKD.Sprint5.Task3.V30.Lib;
namespace Tyuiu.DmiterkoKD.Sprint5.Task3.V30.Test
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
            string p = @"C:\Users\rugis\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(p);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}