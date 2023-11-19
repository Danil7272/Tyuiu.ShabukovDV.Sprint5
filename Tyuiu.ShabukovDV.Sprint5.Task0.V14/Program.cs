using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabukovDV.Sprint5.Task0.V14.Lib;

namespace Tyuiu.ShabukovDV.Sprint5.Task0.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Task0 thg = new Task0(5,
                                  "Шабуков Д. В.",
                                  "СМАРТб-23-2",
                                  "Класс File. Запись данных в текстовый файл",
                                  0,
                                  14,
                                  "Дано выражение вычислить его значение при x = 3, результат сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков после запятой.");

            thg.printHeader();

            Console.WriteLine("        4 * x^3");
            Console.WriteLine("y(x) = ---------");
            Console.WriteLine("        x^3 - 1");
            int x = 3;
            Console.WriteLine("x = " + x);

            thg.printFooter();

            double res2 = (4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1);
            res2 = Math.Round(res2, 3);
            Console.WriteLine("Ответ = " + res2);
            Console.WriteLine();

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан =D");

            Console.ReadLine();
        }
    }
}
