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
        private readonly List<Movie> movies = new List<Movie>();

        public void Add(Movie movie)
        {
            int maxId = 0;
            if (movies.Count > 0) maxId = movies.Max(h => h.Id);
            movie.Id = maxId + 1;
            movies.Add(movie);
        }

        public void Remove(Movie movie)
        {
            if (movies.Contains(movie))
                movies.Remove(movie);
        }


        public Movie GetById(int id)
        {
            return movies.FirstOrDefault(g => g.Id == id);
        }


        public List<Movie> GetAll()
        {
            return movies;
        }

        public void Update(Movie movie)
        {
        }
    }
}
