using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(9, 150);
            //p1.label = "Первая точка";
            //SaveTxt(p1);

            Point p = LoadTxt();
            Console.WriteLine(p.x);
            Console.WriteLine(p.y);
            Console.WriteLine(p.label);
        }

        static Point LoadTxt()
        {
            string path = @"C:\Lesson6\Point.txt";
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (!reader.EndOfStream)
            {
                //list.Add(int.Parse(reader.ReadLine()));
            }
            int x = int.Parse(reader.ReadLine());
            int y = int.Parse(reader.ReadLine());
            string label = reader.ReadLine();
            reader.Close();

            Point p = new Point(x, y);
            p.label = label;

            return p;
        }

        static void SaveTxt(Point p1)
        {
            string path = @"C:\Lesson6\Point.txt";

            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(p1.x);
            writer.WriteLine(p1.y);
            writer.WriteLine(p1.label);

            writer.Close();
        }

        static Point LoadBin()
        {
            string path = @"C:\Lesson6\Point.bin";

            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] mass = new byte[sizeof(int) /*4*/];
            stream.Read(mass, 0, mass.GetLength(0));
            int x = BitConverter.ToInt32(mass, 0);
            stream.Read(mass, 0, mass.GetLength(0));
            int y = BitConverter.ToInt32(mass, 0);
            stream.Close();
            return new Point(x, y);
        }

        static void SaveBin(Point p1)
        {
            string path = @"C:\Lesson6\Point.bin";

            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            byte[] xMass = BitConverter.GetBytes(p1.x);
            stream.Write(xMass, 0, xMass.GetLength(0));
            byte[] yMass = BitConverter.GetBytes(p1.y);
            stream.Write(yMass, 0, yMass.GetLength(0));
            //gfchgjh
            stream.Close();
        }
    }

    class Point
    {
        public int x;
        public int y;
        public string label;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
