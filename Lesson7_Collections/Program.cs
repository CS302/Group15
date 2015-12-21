using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkersLibrary;

namespace Lesson7_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> list = new List<Worker>();
            list.Add(new Manager("Светлана", 23, 96845, 5));
            list.Add(new Driver("Иван", 25, 6461465, "Audi", 256));
            list.Add(new Manager("Елена", 23, 48653, 15));
            list.Add(new Driver("Вася", 25, 6461465, "BMW", 256));
            list.Add(new Manager("Татьяна", 23, 41653, 25));
            //list.AddRange(/*массив*/);
            list.Reverse();
            list[0].Print();
            foreach (Worker item in list)
            {
                item.Print();
            }

            list.Insert(0, new Driver("Женя", 25, 784613, "BMW", 256));
            Console.WriteLine(list.Count);
            Console.WriteLine("**********************");

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("exe", 0);
            dict.Add("txt", 0);
            dict.Add("pdf", 0);

            dict["exe"] += 1;

            Console.WriteLine("**************");

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            //while (stack.Count != 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            int number = stack.Pop();
            Console.WriteLine(number);
            int number1 = stack.Peek();
            Console.WriteLine(number1);

            Console.WriteLine("*************");

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Count);

        }
    }
}
