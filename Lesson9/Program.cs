using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkersLibrary;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Delegates
            // Первый вариант.
            //MyDel deldel = new MyDel(Do);
            //
            //deldel += Do;
            //deldel.Invoke();
            //
            //deldel -= Do;
            //deldel();
            //MyDel deldel = delegate(int x) { Console.WriteLine("Анонимный метод занят какой-то работой. " + x); };
            //MyDel deldel = (a, b) => ( a + b);
            //deldel += (a, b) => ( a - b);
            //int result = deldel(10, 157);
            //Console.WriteLine(result);
            //foreach (var d in //deldel.GetInvocationList())
            //{
            //    result = d(); 
            //}
            #endregion

            Manager man = new Manager("Vasya", 34, 12345678, 10);
            Console.WriteLine("Сериализуем менеджера.");
            SerializeXML(man);
            Console.WriteLine("Сериализация была успешно завершена.");
            Console.WriteLine("Десериализуем объект из файла Binary.dat.");
            Worker w = DeserializeXML();
            Console.WriteLine(w.GetType());
            w.Print();
            Console.ReadLine();
        }

        static void SerializeBinary(Worker w)
        {
            using (FileStream fs = new FileStream("Binary.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    bf.Serialize(fs, w);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static Worker DeserializeBinary()
        {
            Object temp;
            using (FileStream fs = new FileStream("Binary.dat", FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    temp = bf.Deserialize(fs);
                    if (temp is Driver)
                        return temp as Driver;
                    else
                        return temp as Manager;
                }
                catch (SerializationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return null;
        }

        static void SerializeXML(Manager w)
        {
            using (StreamWriter fs = new StreamWriter("manager.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Manager));
                try
                {
                    xs.Serialize(fs, w);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        static Worker DeserializeXML()
        {
            Manager temp = null;
            using (StreamReader fs = new StreamReader("manager.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Manager));
                try
                {
                    temp = xs.Deserialize(fs) as Manager;
                }
                catch (SerializationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return temp;

            //return new XmlSerializer(typeof(Worker)).Deserialize(new FileStream("Binary.dat", FileMode.Open)) as Manager;
        }
    }
}
