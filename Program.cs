using System;

namespace greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите номер дня Вашего рождения");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер месяца Вашего рождения");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год Вашего рождения");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime now = DateTime.Today;
            int thisyear = now.Year;
            int thismonth = now.Month;
            int thisday = now.Day;
            int age;
            if (thismonth > month || month == thismonth && thisday >= day)
            {
              age = thisyear - year;
            }
            else
            age = thisyear - year -1;
            if (day < 1 || day > 31 || month < 1 || month > 12)
            {
                Console.WriteLine("Ошибка");
            }
            if (month == 2 && (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) && day >29) //високосный
            {
                 Console.WriteLine("Ошибка");
            }
            if (month == 2 && !(((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) && day > 28)
            {
                Console.WriteLine("Ошибка");
            }
            else
                Console.WriteLine($"Здравствуйте, {name} ,Ваш возраст равен {age} лет. Приятно познакомиться.");
                {

                    Console.ReadKey();
                }
            }
        }
    }


