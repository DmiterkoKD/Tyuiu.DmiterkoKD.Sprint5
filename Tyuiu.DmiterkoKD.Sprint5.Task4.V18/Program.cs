using Tyuiu.DmiterkoKD.Sprint5.Task4.V18.Lib;
namespace Tyuiu.DmiterkoKD.Sprint5.Task4.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Дмитерко К.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила: Дмитерко Кира Дмитриевна | ИБКСб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая подчитает значения выражения                *");
            Console.WriteLine("* и сохранить результат в текстовый файл OutPutFileTask1.bin              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V18.txt");
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.LoadFromDataFile(path));
        }
    }
}
