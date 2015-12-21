using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Work work = new Work();
                work.Start();
                
            }
            catch 
            {
                Console.WriteLine("Что-то пошло не так. Обратитесь к системному администратору.");
            }
            
        }
    }

    class Work
    {
        public void Start()
        {
            //Square();
            //ShowExceptions();
            int a = 2000000000;
            int b = 2000000000;
            //throw new Exception("А мне захотелось.");
            try
            {
                checked
                {
                    int c = a + b;
                    Console.WriteLine(c);
                }
                
            }
            catch
            {
                Console.WriteLine("Переполнение");
            }
            Console.WriteLine(a+b);
            Console.WriteLine("*********");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
        }

        private static void ShowExceptions()
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(100.0 / x);
                //double y = double.PositiveInfinity;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Вводить можно только цифры");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Введено слишком большое число.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Делить на ноль нельзя.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Что-то пошло не так. Попробуйте еще раз.");
            }
        }

        private static void Square()
        {
            while (true)
            {
                Console.WriteLine("Введите число:");
                int number;
                try
                {
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number * number);
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Вводить нужно числа!");
                    Console.WriteLine("Попробуйте еще раз");
                }
                //finally
                //{
                //    Console.WriteLine("Что-то выполнилось");
                //}
            }
        }
    }

    [Serializable]
    public class IWantException : Exception
    {
        public IWantException() { }
        public IWantException(string message) : base(message) { }
        public IWantException(string message, Exception inner) : base(message, inner) { }
        protected IWantException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
