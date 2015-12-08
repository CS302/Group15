using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    sealed class Manager : Worker, IPayTax
    {
        public int projCount;

        public Manager(string name, int age, int snn, int projCount)
            :base (name, age, snn)
        {
            this.projCount = projCount;
            salary = 50000;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Кол-во проектов: " + projCount);
            Console.WriteLine("З/П: " + (int)(salary + GetBonus()));
            Console.WriteLine();
        }

        public override double GetBonus()
        {
            return projCount * 1500;
        }

        public double PayTax()
        {
            return salary * 0.13;
        }
    }
}
