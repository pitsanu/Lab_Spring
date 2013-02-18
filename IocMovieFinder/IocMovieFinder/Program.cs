using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Context;
using Spring.Context.Support;

namespace IocMovieFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IApplicationContext ctx = ContextRegistry.GetContext();
                MovieLister lister = (MovieLister)ctx.GetObject("MyMovieLister");            

                Movie[] movies = lister.MoviesDirectedBy("Roberto Benigni");
                Console.WriteLine("\nSearching for movie...\n");
                foreach (Movie movie in movies)
                {
                    Console.WriteLine(
                        string.Format("Movie Title = '{0}', Director = '{1}'.",
                        movie.Title, movie.Director));
                }
                Console.WriteLine("\nMovieApp Done.\n\n");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            Console.WriteLine("Press a key to exit...");
            Console.ReadKey();
        }
    }
}
