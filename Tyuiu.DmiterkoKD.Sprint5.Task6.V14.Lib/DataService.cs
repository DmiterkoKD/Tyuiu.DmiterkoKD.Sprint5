using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.DmiterkoKD.Sprint5.Task6.V14.Lib
{
    public class DataService : ISprint5Task6V14
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++) {
                        if (line[i] == '.' || line[i] == '?')
                        {
                            count++;
                        }
                }
            }

        }
    }
}
