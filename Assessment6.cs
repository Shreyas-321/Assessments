using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assessment
{
    
    internal class Assessment6

    {
        public static bool Leapyear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            return false;
        }
                

        public static bool Validate(int year, int month, int day)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, 31);
            hashtable.Add(2, Leapyear(year) ? 29 : 28);
            hashtable.Add(3, 31);
            hashtable.Add(4, 30);
            hashtable.Add(5, 31);
            hashtable.Add(6, 30);
            hashtable.Add(7, 31);
            hashtable.Add(8, 31);
            hashtable.Add(9, 30);
            hashtable.Add(10, 31);
            hashtable.Add(11, 30);
            hashtable.Add(12, 31);
            if (month > 0 && month < 13)
            {
                if (day > 0 && day <= (int)hashtable[month])
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to validate the calender");
            Console.WriteLine("Enter the year: ");
            int Year=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Month: ");
            int Month=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Day: ");
            int Day=int.Parse(Console.ReadLine());
            
            if (Validate(Year, Month, Day))
            {
                Console.WriteLine("valide calander");
            }
            else
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
