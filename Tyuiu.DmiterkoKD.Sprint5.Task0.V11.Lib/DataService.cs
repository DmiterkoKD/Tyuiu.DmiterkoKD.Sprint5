﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.DmiterkoKD.Sprint5.Task0.V11.Lib
{
    public class DataService : ISprint5Task0V11
    {
        public string SaveToFileTextData(int x)
        {
            string p = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double y = (4 - Math.Pow(x, 3)) / Math.Pow(x, 2);
            y = Math.Round(y, 3);
            File.WriteAllText(p,Convert.ToString(y));
            return p;
        }
    }
}
