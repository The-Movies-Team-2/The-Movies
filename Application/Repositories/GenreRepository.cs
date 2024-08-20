﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.DomainModel;

namespace The_Movies.ApplicationLayer.Repositories
{
    internal class GenreRepository
    {
        private List<Genre> genres = new List<Genre>();

        public GenreRepository() {
            Add(new Genre(1, "Drama"));
            Add(new Genre(2, "Gys"));
            Add(new Genre(3, "Action"));
            Add(new Genre(4, "Komedie"));
            Add(new Genre(5, "Science Fiction"));
            Add(new Genre(6, "Romantik"));
            Add(new Genre(7, "Eventyr"));
            Add(new Genre(8, "Krimi"));
            Add(new Genre(9, "Animation"));
            Add(new Genre(10, "Thriller"));
        }

        public void Add(Genre genre)
        {
            //int maxId = 0;
            //if (genres.Count > 0) maxId = genres.Max(h => h.Id);
            //genre.Id = maxId + 1;
            genres.Add(genre);
        }

        public Genre Get(int id)
        {
            return genres.FirstOrDefault(g => g.Id == id);
        }

        public List<Genre> GetAll()
        {
            return genres.OrderBy(g => g.Name).ToList();
        }
    }
}
