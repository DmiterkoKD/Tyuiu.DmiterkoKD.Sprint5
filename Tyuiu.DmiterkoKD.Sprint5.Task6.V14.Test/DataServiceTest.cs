using Tyuiu.DmiterkoKD.Sprint5.Task6.V14.Lib;
namespace Tyuiu.DmiterkoKD.Sprint5.Task6.V14.Test
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
            string p = @"C:\Users\rugis\AppData\Local\Temp\InPutDataFileTask6V14.txt";
            FileInfo fileInfo = new FileInfo(p);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [Test]
        public void Test2()
        {
            DataService ds = new DataService();
            string p = @"C:\Users\rugis\AppData\Local\Temp\InPutDataFileTask6V14.txt";

            var res = ds.LoadFromDataFile(p);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}