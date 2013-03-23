using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Context;
using Spring.Context.Support;
using Common.Logging;
using log4net.Config;

namespace IocMovieFinder
{
    class Program
    {
        private static readonly ILog LOG = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            try
            {
                IApplicationContext ctx = ContextRegistry.GetContext();
<<<<<<< HEAD
                MovieLister lister = (MovieLister)ctx.GetObject("MyMovieLister");
                IMovieFinder finder = (IMovieFinder)ctx.GetObject("AnotherMovieFinder");


                Console.WriteLine(string.Format("Finder: {0}", lister.FinderName));
=======
                MovieLister lister = (MovieLister)ctx.GetObject("MyMovieLister");            
>>>>>>> caf2e4d11c37515c3dfc4de5899aed69b92f9def

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
