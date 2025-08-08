using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Assessment4
    {
        public static void ArrayOperations()
        {
            Console.WriteLine("Enter the datatype: ");
            string datatype=Console.ReadLine();
            Console.WriteLine("Enter the Array Size");
            int n=int .Parse(Console.ReadLine());
            switch (datatype)
            {
                case "int":
                    {
                        int[] arr = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            arr[i] = int.Parse(Console.ReadLine());
                        }
                        Array.ForEach(arr, Console.WriteLine);
                        break;
                    }
                case "float":
                    {
                        float[] arr = new float[n];
                        for (int i = 0; i < n; i++)
                        {
                            arr[i] = float.Parse(Console.ReadLine());
                        }
                        Console.WriteLine(string.Join(", ", arr));
                        break;
                    }

                case "double":
                    {
                        double[] arr = new double[n];
                        for (int i = 0; i < n; i++)
                        {
                            arr[i] = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine(string.Join(", ", arr));
                        break;
                    }
                case string:
                    string[] str = new string[n];
                    for (int i = 0; i < n; i++)
                    {
                        str[i] = Console.ReadLine();
                    }
                    Console.WriteLine(string.Join(", ", str));
                    break;
            
                 default:
                    {
                        Console.WriteLine("Invalid datatype");
                        break;
                    }
                    
            }

            }
            
        
        static void Main(string[] args)
        {
            ArrayOperations();
        }
    }
}
