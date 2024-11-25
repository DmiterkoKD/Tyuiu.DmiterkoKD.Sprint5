using Tyuiu.DmiterkoKD.Sprint5.Task2.V18.Lib;
namespace Tyuiu.DmiterkoKD.Sprint5.Task2.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Дмитерко К.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Дмитерко Кира Дмитриевна | ИБКСб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая в введеной с клавиатуры матрицы заменит     *");
            Console.WriteLine("* значиения и сохранить результат в текстовый файл OutPutFileTask1.txt    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            int[,] m = new int[3, 3] { {3, 8, 4},
                                       {-5, -4, -3 },
                                       {-9, 0, 2 } };
            int rows = m.GetUpperBound(0) + 1;
            int cols = m.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"{m[i, j]}\t");
                }
            }
            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(m);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
        }
    }
}
