using Tyuiu.DmiterkoKD.Sprint5.Task0.V11.Lib;
namespace Tyuiu.DmiterkoKD.Sprint5.Task0.V11.Test
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
            string p = @"C:\Users\rugis\source\repos\Tyuiu.DmiterkoKD.Sprint5\Tyuiu.DmiterkoKD.Sprint5.Task0.V11\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(p);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}