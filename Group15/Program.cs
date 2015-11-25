using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; //объявление
            number = 10; //инициализация
            Console.WriteLine(number);
            number = 100;
            Console.WriteLine(number);

            int number2 = 15;
            Console.WriteLine(number2);

            number = 10 * 26464 - 567;
            number = 10 - number;
            Console.WriteLine(number);
            number = 56 % 10;
            number = 56 / 10;
            Console.WriteLine(number);
            Console.WriteLine("***********************");
            number = 56;
            double number3 = (double)number / 10;
            Console.WriteLine(number3);

            Console.WriteLine("_________________________");

            string text = "6861564";
            int number4 = int.Parse(text);
            number4 = number4 + 10;
            Console.WriteLine(number4);


            Console.WriteLine("a"+"b"+"c");

            char symbol = 'A';
            Console.WriteLine(symbol);
            Console.WriteLine('a'+'b'+'c');
            Console.WriteLine((int)'6');

            bool flag = true;
            flag = true && false; // || = или (логическое сложение) && = и (логическое умножение)
            Console.WriteLine(flag);
            flag = !false; //унарное логическое отрицание

            Console.WriteLine("*******************");
            int x = -10;
            int y = -x;
            Console.WriteLine(y);


            x = 5;
            x++; // x = x + 1 эквивалентны

            x += 20; // x = x + 20 эквивалентны

            Console.WriteLine(x);

            Console.WriteLine("====================");

            

            DateTime date = new DateTime(2015, 11, 25, 19, 31, 0);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.DayOfWeek);

            DayOfWeek day = DayOfWeek.Friday; //перечисление
            Console.WriteLine((int)day);
            Console.WriteLine((DayOfWeek)5);

            Console.ForegroundColor = ConsoleColor.Yellow; //перечисление
            Console.WriteLine("Желтенький");
            Console.WriteLine("Еще что-то");
            Console.ForegroundColor = ConsoleColor.Gray;

            Users user = Users.Guest;
            Console.WriteLine("Авторизуйтесь");
        }
    }
    enum Users //собственное перечисление
    {
        Admin,
        Guest,
        Banned,
        AuthUser
    }
}
