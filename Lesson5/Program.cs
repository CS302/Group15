using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            // nAmE JbIOhL
            // Name Jbiohl

            //ShowString();

            /*Point p1 = new Point(12.5413, 45.461);
            Console.WriteLine();
            Console.WriteLine("{0:e}", p1);
            //[1.25413e+001; 4.5461e+001]
            Console.WriteLine("{0:csv}", p1);
            //[12.54;45.46]


            Console.WriteLine();
            //Console.WriteLine("Первая координата = " + p1.x);
            //Console.WriteLine("Вторая координата = " + p1.y);

            Console.WriteLine("координата X = {0}\nкоордината Y = {1}", p1.x, p1.y);

            string coord = string.Format("координата X = {0}\nкоордината Y = {0}", p1.x, p1.y);


            Console.WriteLine();

            double price = 1.0/3;
            Console.WriteLine("Цена = {0}", price);

            Console.WriteLine("Цена = {0:e}", price);

            Console.WriteLine("Цена = {0:c}", price);

            Console.WriteLine("Цена = {0:.0000}", price);

            Console.WriteLine("Цена = {0:.##}", price);*/


            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine("{0:hh:mm}", date);
            Console.WriteLine("{0:yyyy.MMMM.dd HH:mm:ss:fff}", date);
        }

        private static void ShowString()
        {
            string text1 = "простой текст";
            string text2 = text1;

            text1 = "123";

            Console.WriteLine(text1);
            Console.WriteLine(text2);

            /*Console.WriteLine("**********");

            Point p1 = new Point(100);
            Point p2 = new Point(200);
            p1 = p2;
            p2.x = 300;
            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);*/

            //string text = "первая\r123"; //"\a";
            //Console.WriteLine(text);
            string[] symbols = new string[] { "|", "/", "-", "\\" };
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(symbols[i % 4] + "\r");
                //Thread.Sleep(500);
            }

            string path = @"C:\Lesson5\1.txt";
            //Console.WriteLine("Введите путь к файлу:");
            //string path2 = Console.ReadLine();
            char symbol = '\'';
            Console.WriteLine(symbol);
            Console.WriteLine("Наши занятия 'легкие'");
            text1 = @"первая строка
вторая строка
                примечание";
            Console.WriteLine(text1);
            Console.WriteLine("**************");
            Console.WriteLine("**************");

            string text = "простая строка";
            Console.WriteLine(text.Length);
            Console.WriteLine(text[0]);

            Console.WriteLine(text.CompareTo("сложная строка"));
            Console.WriteLine(text.Contains("стр"));

            Console.WriteLine();

            Console.WriteLine(text.Insert(0, "Это "));
            Console.WriteLine(text.Remove(8, 3));
            text = text.Insert(0, "Это ");
            Console.WriteLine(text);

            Console.WriteLine();

            Console.WriteLine(text.Replace("простая", "сложная"));

            string data1 = "12 54 664 6 311 6 6465 84";
            string[] items = data1.Split(' ');
            int sum = 0;
            for (int i = 0; i < items.GetLength(0); i++)
            {
                sum += int.Parse(items[i]);
            }
            Console.WriteLine(sum);
            
            string username = "Username ";
            Console.WriteLine("|" + username + "|");
            username = username.Trim(' ');
            Console.WriteLine("|" + username + "|");

            int n = 1000000;
            StringBuilder data = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                data.Append(i);
            }
            //Console.WriteLine(data);
            Console.WriteLine(data.Length);
        }
    }

    class Point : IFormattable
    {
        public double x;
        public double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format)
            {
                case "e":
                    return string.Format("[{0:e} ; {1:e}]", x, y);
                case "csv":
                    return string.Format("({0:.##};{1:.##})", x, y);
                default:
                    return ToString();
            }
        }
    }
}
