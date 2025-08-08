using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Assessment3
    {
        public static double Calculator(double n1, double n2, string Operator)
        {
            switch (Operator)
            {
                case "+":
                    { return n1 + n2; }
                case "-": return n1 - n2;
                case "*": return n1 * n2;
                case "/": return n1 / n2;
                default:
                    Console.WriteLine("Invalid operation");
                    return 0;
            }
            
        }
        public static double GetValue(string str)
        {
            Console.WriteLine(str);
            return double.Parse(Console.ReadLine());
        }
        public static string GetOperator(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine().ToUpper();
        }
            static void Main(string[] args)
            {

                Console.WriteLine("Welcome to Calculator Program:");
            bool choice = false;
                do
                {
                    
                    double n1 = GetValue("Enter the first value:");
                   
                double n2 = GetValue("Enter the second value:");

                string Operator = GetOperator("Enter the operator value:");
                double result = Calculator(n1, n2, Operator);
                    Console.WriteLine(result);

                string str = GetOperator("want to continue or not (Y or N)");
                choice =str=="Y"?true:false;

                } while (choice);


            }
        }
    }

