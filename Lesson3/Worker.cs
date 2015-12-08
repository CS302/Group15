using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    abstract class Worker
    {
        private string name; //поле
        private int age;     //поле
        public int snn;     //поле
        public static int count;
        protected double salary;
        public int Age      //свойство
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Возраст задан неверно");
                }
                else
                {
                    age = value;
                }
            }
            get { return age; }
        }
        public string Name
        {
            get { return name; }
        }

        public abstract double GetBonus();

        public virtual void Print() //метод
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
        }

        public static void PrintWorkers(Worker[] workers)
        {
            for (int i = 0; i < workers.GetLength(0); i++)
            {
                workers[i].Print();
            }
        }

        public Worker(string name, int age, int snn) //параметризованный конструктор
        {
            this.name = name;
            Age = age;
            this.snn = snn;
            count++;
            salary = 20000;
        }

        public Worker(string name, int age)
            : this(name, age, 0)
        {   }

        static Worker()
        {
            count = 0;
        }

        
    }
}
