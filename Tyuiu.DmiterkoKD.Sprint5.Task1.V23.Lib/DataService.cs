using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.DmiterkoKD.Sprint5.Task1.V23.Lib
{
    public class DataService : ISprint5Task1V23
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string p = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(p);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(p);
            }
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Cos(x) + (Math.Cos(x)) / (x + 2) - 3 * x;
                y = Math.Round(y, 2);
                if (x == 0)
                {
                    y = 0;
                }
                strY = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(p, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(p, strY);
                }
            }
            return p;
        }
    }
}
