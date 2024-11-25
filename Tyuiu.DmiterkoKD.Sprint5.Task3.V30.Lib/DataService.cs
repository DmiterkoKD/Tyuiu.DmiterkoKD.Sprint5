using System.IO;
using System.Text;
using System.Text.Unicode;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DmiterkoKD.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        public string SaveToFileTextData(int x)
        {
            string p = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double y = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));
            y = Math.Round(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(p, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return p;
        }
    }
}
