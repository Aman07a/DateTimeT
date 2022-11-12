using System;

namespace DateTimeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Date of birth
            DateTime dateTime = new DateTime(2000, 10, 8);
            Console.WriteLine("My birthday is: {0}.\n", dateTime);

            // Write today on the screen
            Console.WriteLine(DateTime.Today);

            // Write current time on the screen
            Console.WriteLine(DateTime.Now);

            // Write tomorrow on the screen
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("\nTomorrow will be the: {0}", tomorrow);

            // Write which day of the week on the screen
            Console.WriteLine("Today is: {0}.\n", DateTime.Today.DayOfWeek);

            // Write first day of the year on the screen
            Console.WriteLine("First day of the year is: {0}.\n", GetFirstDayOfYear(2000));

            // Write how many days are in a month on the screen
            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000: {0}.", days);
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine("Days in Feb 2001: {0}.", days);
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("Days in Feb 2004: {0}.\n", days);

            // Write only minutes from todays date
            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: {0}.", now.Minute);

            // Write only hours from todays date
            Console.WriteLine("Hour: {0}.\n", now.Hour);

            // Display the time in this structure {x} o'clock {y} minutes and {z} seconds
            Console.WriteLine("{0} o'clock {1} minutes {2} seconds.", now.Hour, now.Minute, now.Second);

            // Write a date in this format: yyyy-mm-dd on the screen
            Console.WriteLine("\nWrite a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("You are {0} days old.", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
