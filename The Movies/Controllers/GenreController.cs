using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.DataHandlers;
using The_Movies.Model;
using The_Movies.Repositories;

namespace The_Movies.Controllers
{
    internal class GenreController
    {
        private readonly GenreRepository repository;
        private readonly GenreDataHandler dataHandler;
        public GenreController()
        {
            repository = new GenreRepository();
            dataHandler = new GenreDataHandler();
        }

        public virtual List<Genre> GetAll()
        {
            return repository.GetAll().ToList();
        }
    }
}
