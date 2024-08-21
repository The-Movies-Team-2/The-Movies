using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.DataHandlers.DomainDataHandlers;
using The_Movies.ApplicationLayer.Repositories;
using The_Movies.DomainModel;


namespace The_Movies.ApplicationLayer.Controllers
{
    public class GenreController
    {
        private readonly GenreRepository _repository;
        private readonly GenreDataHandler _dataHandler;
        public GenreController()
        {
            _repository = new GenreRepository();
            _dataHandler = new GenreDataHandler();
        }

        public virtual List<Genre> GetAll()
        {
            return _repository.GetAll().ToList();
        }
    }
}
