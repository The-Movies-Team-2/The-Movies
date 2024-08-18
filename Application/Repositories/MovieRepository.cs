using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.DomainModel;

namespace The_Movies.ApplicationLayer.Repositories
{
    internal class MovieRepository
    {
        private List<Movie> movies = new List<Movie>();

        public void Add(Movie movie)
        {
            int maxId = 0;
            if (movies.Count > 0) maxId = movies.Max(h => h.Id);
            movie.Id = maxId + 1;
            movies.Add(movie);
        }
        public List<Movie> GetAll()
        {
            return movies;
        }
    }
}
