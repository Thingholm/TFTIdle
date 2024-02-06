using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies
{
    internal class MoviesRepository
    {
        private List<Movie> movieList = new List<Movie>();

        public List<Movie> MovieList
        {
            get { return movieList; }
            set { movieList = value; }
        }

        public MoviesRepository()
        {
            using (StreamReader sr = new StreamReader("movies.csv"))
            {
                string header = sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null && line != header)
                {
                    List<string> csvList = new List<string>(line.Split(";"));
                    MovieList.Add(new Movie(csvList));
                }
            }
        }

        public void AddMovie(Movie movie)
        {
            movieList.Add(movie);
        }
    }
}
