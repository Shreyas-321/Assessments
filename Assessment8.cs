using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assessment
{
    internal class Assessment8
    {
        public static void printCalendar(int month, int year)
        {
            // Validate month
            if (month < 1 || month > 12)
            {
                Console.WriteLine("❌ Invalid month. Please enter a value between 1 and 12.");
                return;
            }

            // Validate year
            if (year < 1)
            {
                Console.WriteLine("❌ Invalid year. Please enter a positive value.");
                return;
            }

            // Get the first day of the month and number of days
            DateTime firstDay = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            DayOfWeek startDay = firstDay.DayOfWeek;

            // Print the header
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
            Console.WriteLine($"\n📅 {monthName} {year}");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            // Initial spacing
            int indent = (int)startDay;
            for (int i = 0; i < indent; i++)
            {
                Console.Write("    ");
            }

            // Print the days
            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"{day,3} ");
                indent++;
                if (indent % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine(); // Final newline
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the year: ");
            int year = int.Parse(Console.ReadLine());

            printCalendar(month, year);
        }
    }
}
