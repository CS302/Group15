﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    sealed class Driver : Worker, IPayTax
    {
        public string carType;
        public int hours;

        public Driver(string name, int age, int snn, string carType, int hours)
            : base(name, age, snn)
        {
            this.carType = carType;
            this.hours = hours;
            salary = 45000;
        }

        public override double GetBonus()
        {
            return hours * 100;
        }


        public override void Print()
        {
            base.Print();
            Console.WriteLine("Машина: " + carType);
            Console.WriteLine("Часы: " + hours);
            Console.WriteLine("З/П: " + (int)(salary+GetBonus()));
            Console.WriteLine();
        }

        public double PayTax()
        {
            return salary * 0.13;
        }
    }
}
