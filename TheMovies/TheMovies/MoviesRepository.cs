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
                sr.Close();
            }
        }

        public void AddMovie(Movie movie)
        {
            movieList.Add(movie);
            using (StreamWriter sw = new StreamWriter("movies.csv", append: true))
            {
                sw.WriteLine(movie.ToString());
            }
        }

        public void RemoveMovie(Movie movie)
        {
            movieList.Remove(movie);
            using (StreamWriter sw = new StreamWriter("movies.csv"))
            {
                foreach (Movie m in movieList)
                {
                    sw.WriteLine(m.ToString());
                }
            }
        }
    }
}
