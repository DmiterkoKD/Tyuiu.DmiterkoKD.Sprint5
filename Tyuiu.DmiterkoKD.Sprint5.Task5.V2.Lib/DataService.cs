using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.DmiterkoKD.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            string[] strNum = File.ReadAllLines(path);
            double[] nums = Array.ConvertAll(strNum[0].Split(','), double.Parse);
            int k = 0;
            double res = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > 0)
                {
                    k++;
                    res += nums[i];
                }
            }
            double x = Math.Round((res / k), 3);
            return x;
        }
    }
}
