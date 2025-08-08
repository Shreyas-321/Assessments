using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assessment
{

    internal class Assement7
    {
        public static bool isPrimeNumber(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (isPrimeNumber(num))
            {
                Console.WriteLine($"the number {num} is a prime number ");
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
        }
    }
}
