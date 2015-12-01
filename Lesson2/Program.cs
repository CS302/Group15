using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowArrays();
            //ShowIfSwitch();


            //ShowFor();

            /*string comand = Console.ReadLine();
            while (comand != "exit")
            {
                Console.WriteLine("Выполняется работа");
                comand = Console.ReadLine();
            }*/


            /*string comand;
            do
            {
                Console.WriteLine("Выполняется работа");
                comand = Console.ReadLine();

            } while (comand != "exit");*/


            for (int i = 0; i < 15; i++)
            {
                if (i == 10)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            int[,] table1 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < table1.GetLength(0); i++)
            {
                for (int j = 0; j < table1.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                    {
                        table1[i, j] = 1;
                    }
                    else
                    {
                        table1[i, j] = 0;
                    }
                }
                Console.WriteLine();
            }
        }

        private static void ShowFor()
        {
            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            } 
            Console.WriteLine("****************");

            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void ShowIfSwitch()
        {
            int x = 3;
            string text = Console.ReadLine();
            if ((text == "exit") && (x == 4))
            {
                Console.WriteLine("Работа приложения завершена");
            }
            if (text == "pause")
            {
                Console.WriteLine("Приложение приостановлено");
            }
            else
            {
                Console.WriteLine("Выполняется какая-то работа");
            }

            switch (text)
            {
                case "exit":
                    Console.WriteLine("Работа завершена");
                    break;
                case "pause":
                    Console.WriteLine("Рабта приостановлена");
                    break;
                case "option1":
                case "option2":
                    Console.WriteLine("Выбрана опция...");
                    break;
                default:
                    Console.WriteLine("Неверно введена команда");
                    break;
            }
        }

        private static void ShowArrays()
        {
            int number = 10;
            int[] numbers = new int[5];
            numbers[0] = 11;
            numbers[1] = 97456;
            numbers[2] = 1;
            numbers[3] = 89465;
            numbers[4] = 498;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine("--------------");
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.GetLength(0));

            Console.WriteLine("***************");

            int[,] table = new int[2, 3];
            table[0, 0] = 1;
            table[0, 1] = 2;
            table[0, 2] = 3;
            table[1, 0] = 4;
            table[1, 1] = 5;
            table[1, 2] = 6;

            Console.Write(table[0, 0] + " ");
            Console.Write(table[0, 1] + " ");
            Console.WriteLine(table[0, 2] + " ");
            Console.Write(table[1, 0] + " ");
            Console.Write(table[1, 1] + " ");
            Console.WriteLine(table[1, 2] + " ");
            Console.WriteLine("----------");
            Console.WriteLine(table.Length);
            Console.WriteLine(table.GetLength(0));
            Console.WriteLine(table.GetLength(1));

            int[,] table1 = { { 1, 2, 3 }, { 4, 5, 6 } };


            Console.WriteLine("*******************");

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[2] { 5, 6 };
            jaggedArray[2] = new int[3] { 7, 8, 9 };

            Console.WriteLine(jaggedArray[0][0] + " " + jaggedArray[0][1] + " " + jaggedArray[0][2] + " " + jaggedArray[0][3]);
            Console.WriteLine(jaggedArray[1][0] + " " + jaggedArray[1][1]);
        }

        static void DoSmth()
        {
            int a = 10;
            int b = 15;
            Console.WriteLine("Выполнение метода");
            Console.WriteLine(a + "" + b);
        }

        static void PrintSum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Результат работы метода = " + sum);
        }

        static int CalcSum(int a, int b)
        {
            return a + b;
        }
    }
}
