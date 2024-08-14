using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.Model;

namespace The_Movies.Applikation
{
    internal class GenreRepository
    {
        private List<Genre> genres = new List<Genre>();

        public void Add (Genre genre) 
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
