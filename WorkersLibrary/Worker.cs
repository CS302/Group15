using System;

namespace WorkersLibrary
{
    [Serializable]
    public abstract class Worker
    {
        #region Поля

        private string name; //поле
        private int age;     //поле
        private int snn;     //поле

        
        public static int count;
        protected double salary;

        #endregion

        #region Свойства
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

        public int Snn
        {
            get { return snn; }
            set { snn = value; }
        }
        #endregion

        #region Методы
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
        
        #endregion

        #region Конструкторы
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
        { }

        public Worker()
        { }

        static Worker()
        {
            count = 0;
        } 
        #endregion



    }
}
