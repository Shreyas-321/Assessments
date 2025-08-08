using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Assessment9
    {
        public static string reverseByWords(string sentence)
        {
            string[] str = Regex.Split(sentence.Trim(), @"\s+");
            StringBuilder sb =new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i] + " ");
            }
            return sb.ToString();
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the shring");
            string str=Console.ReadLine();
            Console.WriteLine(reverseByWords(str));
            
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assingments_Bhuvanj
//{
//    internal class Assignment5
//    {
//        class Movie()

//        {


//            public int Id { get; set; }
//            public string Title { get; set; }
//        }

//        static List<Movie> movies = new List<Movie>();

//        static void Main()
//        {
//            int choice;
//            do
//            {
//                Console.WriteLine("\n--- Movie Management System ---");
//                Console.WriteLine("1. Add Movie");
//                Console.WriteLine("2. Remove Movie");
//                Console.WriteLine("3. Find Movie by ID");
//                Console.WriteLine("4. Update Movie Title");
//                Console.WriteLine("5. Exit");
//                Console.Write("Enter your choice: ");
//                choice = Convert.ToInt32(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        AddMovie();
//                        break;
//                    case 2:
//                        RemoveMovie();
//                        break;
//                    case 3:
//                        FindMovie();
//                        break;
//                    case 4:
//                        UpdateMovie();
//                        break;
//                    case 5:
//                        Console.WriteLine("Exiting program...");
//                        break;
//                    default:
//                        Console.WriteLine("Invalid choice. Try again.");
//                        break;
//                }
//            } while (choice != 5);
//        }

//        static void AddMovie()
//        {
//            Console.Write("Enter Movie ID: ");
//            int id = Convert.ToInt32(Console.ReadLine());

//            if (movies.Exists(m => m.Id == id))
//            {
//                Console.WriteLine("Movie with this ID already exists.");
//                return;
//            }

//            Console.Write("Enter Movie Title: ");
//            string title = Console.ReadLine();

//            movies.Add(new Movie { Id = id, Title = title });
//            Console.WriteLine("Movie added successfully.");
//        }

//        static void RemoveMovie()
//        {
//            Console.Write("Enter Movie ID to remove: ");
//            int id = Convert.ToInt32(Console.ReadLine());

//            var movie = movies.Find(m => m.Id == id);
//            if (movie != null)
//            {
//                movies.Remove(movie);
//                Console.WriteLine("Movie removed successfully.");
//            }
//            else
//            {
//                Console.WriteLine("Movie not found.");
//            }
//        }

//        static void FindMovie()
//        {
//            Console.Write("Enter Movie ID to find: ");
//            int id = Convert.ToInt32(Console.ReadLine());

//            var movie = movies.Find(m => m.Id == id);
//            if (movie != null)
//            {
//                Console.WriteLine($"ID: {movie.Id}, Title: {movie.Title}");
//            }
//            else
//            {
//                Console.WriteLine("Movie not found.");
//            }
//        }

//        static void UpdateMovie()
//        {
//            Console.Write("Enter Movie ID to update: ");
//            int id = Convert.ToInt32(Console.ReadLine());

//            var movie = movies.Find(m => m.Id == id);
//            if (movie != null)
//            {
//                Console.Write("Enter new Title: ");
//                movie.Title = Console.ReadLine();
//                Console.WriteLine("Movie updated successfully.");
//            }
//            else
//            {
//                Console.WriteLine("Movie not found.");
//            }
//        }
//    }
