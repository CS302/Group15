using System;

namespace Lesson3
{
    public class Lesson3
    {
        public static void Main()
        {
            Worker[] workers = new Worker[5];
            workers[0] = new Manager("Светлана", 23, 96845, 5);
            workers[1] = new Driver("Иван", 25, 6461465, "Audi", 256);
            workers[2] = new Manager("Елена", 23, 48653, 15);
            workers[3] = new Driver("Вася", 25, 6461465, "BMW", 256);
            workers[4] = new Manager("Татьяна", 23, 41653, 25);

            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].Print();
                Console.WriteLine();
            }
            Console.WriteLine("+++++++++++++++++");
            Manager driver1 = new Manager("Елена", 23, 48653, 15);
            Worker worker = driver1;
            
            /*if (worker is Driver)
            {
                Driver dr = (Driver)worker;
                Console.WriteLine(dr.hours);
            }*/

            Driver dr = worker as Driver;
            if (dr != null)
            {
              Console.WriteLine(dr.hours);
            }
            else
            {
                Console.WriteLine("Эта ссылка указывает не на водителя");
            }
        }
    }

}


