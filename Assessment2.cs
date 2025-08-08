using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Assessment2
    {
        public static void OddEven(int[] arr)
        {
            Console.WriteLine("The Odd numbers are: ");
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("The Even numbers are: ");
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
            public static int[] inputdetails()
            {
                Console.WriteLine("Enter the array size:");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                Console.WriteLine("Enter numbers into the array");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                return arr;
            }
        
        static void Main(string[] args)
        {
            // int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Welcome to fine add and even numbers");
            int[] arr=inputdetails();
             OddEven(arr);
            
        }
    }
}
