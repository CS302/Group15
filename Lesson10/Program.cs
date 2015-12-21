using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson10
{
    class Program
    {
        static Queue<int> queue;
        static object block = new object();
        static void Main(string[] args)
        {
            /*
             * ExtJs (Sencha)
             * 
             * |x|y|z|
             * Random(0 - 9)
             * Числа генерируются в разных потоках и сохраняются в массив
             * 
             * Главный поток - пользовательское меню
             * 1) Принимает ставку
             * 2) Выводит три числа на консоль
             * 3) Выводит результат
             * 
             */

            //ShowProc();
            //Func<int, int, int> workItem = GetNumbers;
            //IAsyncResult ires = workItem.BeginInvoke(10, 20, ShowGetNumbersResult, null);
            //
            //while (Console.ReadLine() != "exit")
            //{   }


            queue = new Queue<int>();
            for (int i = 1; i < 100; i++)
            {
                queue.Enqueue(i);
            }
            Action<int> workItem = CalcQueItem;
            workItem.BeginInvoke(1, null, null);
            workItem.BeginInvoke(2, null, null);
            Console.ReadLine();
        }

        static void CalcQueItem(int id)
        {
            int number;
            while (queue.Count != 0)
            {
                lock(block)
                {
                    number = queue.Dequeue();
                }
                
                number *= number;
                Console.WriteLine("{0} - {1}", id, number);
                Thread.Sleep(10);
            }
        }

        static int GetNumbers(int a, int b)
        {
            int sum = 0;
            for (int i = a; i < b; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
                sum += i;
            }
            return sum;
        }

        static void ShowGetNumbersResult(IAsyncResult ires)
        {
            AsyncResult res = (AsyncResult)ires;
            Func<int, int, int> workItem = (Func<int, int, int>)res.AsyncDelegate;
            int sum = workItem.EndInvoke(ires);
            Console.WriteLine("Сумма = {0}", sum);
        }

        private static void ShowProc()
        {
            Process[] processes = Process.GetProcesses();
            //foreach (Process item in processes)
            //{
            //    Console.WriteLine(item.ProcessName);
            //    Console.WriteLine(item.PeakPagedMemorySize64);
            //    Console.WriteLine();
            //}
            //foreach (Process item in processes)
            //{
            //    if (item.ProcessName == "notepad++")
            //    {
            //        Console.WriteLine("Закрыт");
            //        item.Kill();
            //    }
            //}
            //Process.Start("notepad++", @"C:\Lesson6\Point.txt");
            //Process.Start("chrome", @"http:\\google.com");

            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "notepad++";
            info.Arguments = @"C:\Lesson6\Point.txt";
            info.WindowStyle = ProcessWindowStyle.Minimized;
            Process.Start(info);
        }
    }
}
