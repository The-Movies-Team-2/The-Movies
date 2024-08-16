using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.Model;

namespace The_Movies.Repositories
{
    internal class GenreRepository
    {
        private List<Genre> genres = new List<Genre>();

        public GenreRepository() {
            Add(new Genre("Drama"));
            Add(new Genre("Gys"));
            Add(new Genre("Action"));
            Add(new Genre("Komedie"));
            Add(new Genre("Science Fiction"));
            Add(new Genre("Romantik"));
            Add(new Genre("Eventyr"));
            Add(new Genre("Krimi"));
            Add(new Genre("Animation"));
            Add(new Genre("Thriller"));
        }

        public void Add(Genre genre)
        {
            int maxId = 0;
            if (genres.Count > 0) maxId = genres.Max(h => h.Id);
            genre.Id = maxId + 1;
            genres.Add(genre);
        }

        public List<Genre> GetAll()
        {
            return genres;
        }
    }
}
