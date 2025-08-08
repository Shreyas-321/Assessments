using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class MovieDetails
    {
        int movieid;
        string title;
        string language;
        string showtime;
        public int Movieid
        {
            get { return movieid; }
            set { movieid = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Language
        {
            get { return language; }

            set { language = value; }
        }
        public string Showtime
        {
            get { return showtime; }
            set { showtime = value; }
        }
    }
    class MovieRepo
    {
         static List<MovieDetails> movies=new List<MovieDetails>();
        public void  AddMovie(MovieDetails details)
        {
            movies.Add(details);
            Console.WriteLine($"the name of the movie is {details.Title}");
        }
        public  MovieDetails GetId(int id)
        {
            return movies.Find(details=> details.Movieid==id);
        }
        public MovieDetails[] GetMovie()
        {
            return movies.ToArray();
        }
        public void UpdateMovie(MovieDetails m)
        {
            for(int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Movieid == m.Movieid)
                {
                    movies[i]=new MovieDetails();
                    movies[i].Movieid=m.Movieid;
                    movies[i].Title=m.Title;
                    movies[i].Language=m.Language;
                    movies[i].Showtime=m.Showtime;
                    Console.WriteLine($"Moviename {m.Title} updated successfully.");
                    return;
                }
            }
        }
        public  void  DeleteMovie(int id)
        {
            var rec=movies.Find(details=> details.Movieid==id);
            if (rec != null)
            {
                 movies.Remove(rec);
                Console.WriteLine($"Movie with ID {id} deleted successfully.");
            }
            else
            {
                Console.WriteLine("The Id is Not found");
                return;
            }

        }
    }
    
        internal class Assessment5
        {
        static MovieRepo movierepo = new MovieRepo();
        
            static void Main(string[] args)
            {
                bool processing = false;
                do
                {
                    Console.WriteLine("Enter the Choice as 1 to Addmovie, 2 to findmovie, 3 to Display All, 4 to Update and 5 to Delete");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    processing = processMenu(choice);
                } while (processing);
            }
            public static bool processMenu(int choice)
            {
                switch (choice)
                {
                    case 1: addmoviedetails(); return true;
                    case 2: findmovie(); return true;
                    case 3: Displaymovie(); return true;
                    case 4: updatemovie(); return true;
                    case 5: deletemovie(); return true;
                    default:
                        return false;
                }
            }
        public static void  deletemovie()
        {
            int id = ConsoleUtil.GetInputInt("Enter the Id :");
            movierepo.DeleteMovie(id);
            
        }
        public static void updatemovie()
        {
            MovieDetails details = new MovieDetails();
            details.Movieid = ConsoleUtil.GetInputInt("Enter the movie Id: ");
            details.Title = ConsoleUtil.GetInputString("Enter the movie name: ");
            details.Language = ConsoleUtil.GetInputString("Enter the language of the movie: ");
            details.Showtime = ConsoleUtil.GetInputString("Enter the Show time: ");
            movierepo.UpdateMovie(details);

        }
        public static void addmoviedetails()
        {
            MovieDetails details = new MovieDetails();
            details.Movieid = ConsoleUtil.GetInputInt("Enter the movie Id: ");
            details.Title = ConsoleUtil.GetInputString("Enter the movie name: ");
            details.Language = ConsoleUtil.GetInputString("Enter the language of the movie: ");
            details.Showtime = ConsoleUtil.GetInputString("Enter the Show time: ");
            movierepo.AddMovie(details);


        }
        public static void findmovie()
        {
            Console.WriteLine("Enter the MovieId: ");
            int id=int.Parse(Console.ReadLine());
            MovieDetails moviedetails = movierepo.GetId(id);
            if (moviedetails != null)
            {
                Console.WriteLine($"Employee Found: ID={moviedetails.Movieid}, Name={moviedetails.Title}, Language={moviedetails.Language}, ShowTime={moviedetails.Showtime}");
            }
            else
            {
                Console.WriteLine($"No Employee found with ID {id}");
            }
            

        }
        public static void Displaymovie()
        {
            var x = movierepo.GetMovie();
            foreach(MovieDetails moviedetails in x)
            {
                Console.WriteLine($"{moviedetails.Movieid} {moviedetails.Title} {moviedetails.Language} {moviedetails.Showtime}");
            }
        }

        static class ConsoleUtil
        {
            public static string GetInputString(string question)
            {
                Console.WriteLine(question);
                return Console.ReadLine();
            }

            public static int GetInputInt(string question)
            {
                return int.Parse(GetInputString(question));
            }

            public static double GetInputDouble(string question) => double.Parse(GetInputString(question));
        }
    }
    }
    