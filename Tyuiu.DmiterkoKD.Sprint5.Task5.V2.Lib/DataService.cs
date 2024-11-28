using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.DmiterkoKD.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            int k = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    double x = Convert.ToDouble(line);
                    k++;
                    if (x > 0)
                    {
                        res += x;
                    }                    
                }
                double a = Math.Round((res / k), 3);
                return a;
                
            }
        }
    }
}
