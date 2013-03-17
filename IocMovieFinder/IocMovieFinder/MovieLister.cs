using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Spring.Objects.Factory.Attributes;

namespace IocMovieFinder
{
    class MovieLister
    {
        IMovieFinder _movieFinder;

        [Required]
        IMovieFinder MovieFinder
        {
            get { return _movieFinder; }
            set { _movieFinder = value; }
        }

        public string FinderName { get { return _movieFinder.Name; } }

        public Movie[] MoviesDirectedBy(string director)
        {
            IList allMovies = _movieFinder.FindAll();
            IList movies = new ArrayList();
            foreach (Movie m in allMovies)
            {
                if (director.Equals(m.Director))
                {
                    movies.Add(m);
                }
            }
            return (Movie[])ArrayList.Adapter(movies).ToArray(typeof(Movie));
        }
    }
}
